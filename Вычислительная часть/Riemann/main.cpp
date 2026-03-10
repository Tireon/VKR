#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <math.h>
#include "Riemann_solver.h"

#define SOD_PROBLEM                  1
#define HARTEN_HYMAN_PROBLEM         2
#define LEFT_VACUUM_PROBLEM          3
#define RIGHT_VACUUM_PROBLEM         4
#define VACUUM_PROBLEM               5
#define VACUUM_RAREFACTIONS_PROBLEM  6
#define STANDARD_PROBLEM             7
#define TANGENTIAL_PROBLEM           8


double f(double P, double p, double rho)
{
	double pi, chi, beta, c;

	pi = P / p;
	chi = (gamma - 1.0) / (2.0 * gamma);
	beta = sqrt((gamma + 1.0) / (2.0 * gamma) * pi + (gamma - 1.0) / (2.0 * gamma));
	c = sqrt(gamma * p / rho);

	if (P >= p) {
		return (P - p) / (rho * c * beta);
	}
	else {
		return 2.0 * c / (gamma - 1.0) * (pow(pi, chi) - 1.0);
	}
}

double dfdP(double P, double p, double rho)
{
	double pi, chi, beta, c;

	pi = P / p;
	chi = (gamma - 1.0) / (2.0 * gamma);
	beta = sqrt((gamma + 1.0) / (2.0 * gamma) * pi + (gamma - 1.0) / (2.0 * gamma));
	c = sqrt(gamma * p / rho);

	if (P >= p) {
		return ((gamma + 1.0) * pi + 3.0 * gamma - 1.0)
			/ (4.0 * rho * c * gamma * beta * beta * beta);
	}
	else {
		return c / (gamma * P) * pow(pi, chi);
	}
}

double F(double P, double p1, double rho1, double p2, double rho2)
{
	return f(P, p1, rho1) + f(P, p2, rho2);
}

void Riemann_solver(double xi,
	double rho1, double u1, double v1, double w1, double p1,
	double rho2, double u2, double v2, double w2, double p2,
	double* rho, double* u, double* v, double* w, double* p)
{
	double P0, P, c1, c2, a1, a2, U, m, W1, W2, R, Wa1, Wa2,
		ca, rhoa, ua, pa, U0, dP;
	int num_iter;

	/* vacuum - rarefaction ---------------------------------------*/
	if ((rho1 == 0.0) && (rho2 != 0.0)) {
		c2 = sqrt(gamma * p2 / rho2);
		Wa2 = u2 - 2.0 / (gamma - 1.0) * c2;
		W2 = u2 + c2;
		if (xi < Wa2) {
			*rho = 0.0;
			*u = 0.0;
			*v = 0.0;
			*w = 0.0;
			*p = 0.0;
		}
		else if (xi > W2) {
			*rho = rho2;
			*u = u2;
			*v = v2;
			*w = w2;
			*p = p2;
		}
		else {
			ca = 2.0 / (gamma + 1.0) * c2 - (gamma - 1.0) / (gamma + 1.0) * (u2 - xi);
			rhoa = rho2 * pow(ca / c2, 2.0 / (gamma - 1.0));
			ua = xi - ca;
			pa = p2 * pow(ca / c2, 2.0 * gamma / (gamma - 1.0));
			*rho = rhoa;
			*u = ua;
			*v = v2;
			*w = w2;
			*p = pa;
		}
		return;
	}
	/* end of vacuum - rarefaction --------------------------------*/

	/* rarefaction - vacuum ---------------------------------------*/
	if ((rho1 != 0.0) && (rho2 == 0.0)) {
		c1 = sqrt(gamma * p1 / rho1);
		Wa1 = u1 + 2.0 / (gamma - 1.0) * c1;
		W1 = u1 - c1;
		if (xi > Wa1) {
			*rho = 0.0;
			*u = 0.0;
			*v = 0.0;
			*w = 0.0;
			*p = 0.0;
		}
		else if (xi < W1) {
			*rho = rho1;
			*u = u1;
			*v = v1;
			*w = w1;
			*p = p1;
		}
		else {
			ca = 2.0 / (gamma + 1.0) * c1 + (gamma - 1.0) / (gamma + 1.0) * (u1 - xi);
			rhoa = rho1 * pow(ca / c1, 2.0 / (gamma - 1.0));
			ua = xi + ca;
			pa = p1 * pow(ca / c1, 2.0 * gamma / (gamma - 1.0));
			*rho = rhoa;
			*u = ua;
			*v = v1;
			*w = w1;
			*p = pa;
		}
		return;
	}
	/* end of rarefaction - vacuum --------------------------------*/

	/* vacuum -----------------------------------------------------*/
	if ((rho1 == 0.0) && (rho2 == 0.0)) {
		*rho = 0.0;
		*u = 0.0;
		*v = 0.0;
		*w = 0.0;
		*p = 0.0;
		return;
	}
	/* end of vacuum ----------------------------------------------*/

	c1 = sqrt(gamma * p1 / rho1);
	c2 = sqrt(gamma * p2 / rho2);

	U0 = -2.0 / (gamma - 1.0) * (c1 + c2);

	/* rarefaction - vacuum - rarefaction -------------------------*/
	if ((u1 - u2) < U0) {
		c1 = sqrt(gamma * p1 / rho1);
		Wa1 = u1 + 2.0 / (gamma - 1.0) * c1;
		W1 = u1 - c1;

		c2 = sqrt(gamma * p2 / rho2);
		Wa2 = u2 - 2.0 / (gamma - 1.0) * c2;
		W2 = u2 + c2;

		if (xi < W1) {
			*rho = rho1;
			*u = u1;
			*v = v1;
			*w = w1;
			*p = p1;
		}
		else if ((xi >= W1) && (xi <= Wa1)) {
			ca = 2.0 / (gamma + 1.0) * c1 + (gamma - 1.0) / (gamma + 1.0) * (u1 - xi);
			rhoa = rho1 * pow(ca / c1, 2.0 / (gamma - 1.0));
			ua = xi + ca;
			pa = p1 * pow(ca / c1, 2.0 * gamma / (gamma - 1.0));
			*rho = rhoa;
			*u = ua;
			*v = v1;
			*w = w1;
			*p = pa;
		}
		else if ((xi > Wa1) && (xi < Wa2)) {
			*rho = 0.0;
			*u = 0.0;
			*v = 0.0;
			*w = 0.0;
			*p = 0.0;
		}
		else if ((xi >= Wa2) && (xi <= W2)) {
			ca = 2.0 / (gamma + 1.0) * c2 - (gamma - 1.0) / (gamma + 1.0) * (u2 - xi);
			rhoa = rho2 * pow(ca / c2, 2.0 / (gamma - 1.0));
			ua = xi - ca;
			pa = p2 * pow(ca / c2, 2.0 * gamma / (gamma - 1.0));
			*rho = rhoa;
			*u = ua;
			*v = v2;
			*w = w2;
			*p = pa;
		}
		else {
			*rho = rho2;
			*u = u2;
			*v = v2;
			*w = w2;
			*p = p2;
		}
		return;
	}
	/* end of rarefaction - vacuum - rarefaction ------------------*/

	a1 = rho1 * c1;
	a2 = rho2 * c2;
	/* Godunov */
	P0 = (p1 * a2 + p2 * a1 + (u1 - u2) * a1 * a2) / (a1 + a2);

	if (P0 <= 0.0) {
		/* Toro */
		P0 = p1 + p2 + 0.25 * sqrt(rho1 * rho2) * (c1 + c2) * (u1 - u2);
	}
	if (P0 <= 0.0) {
		/* select is outhere... */
		P0 = eps;
	}
	else if (P0 <= 0.0) {
		printf("I'm sorry...\n\
			But I don't find good P0.\n\
			Stop computations.\n");
		exit(1);
	}

	printf("P0 = %E\t", P0);

	P = P0;
	dP = 10.0 * DBL_EPSILON;
	num_iter = 0;
	do {
		/*P0 = P;
		P = P0 - (f(P0, p1, rho1) + f(P0, p2, rho2) - (u1-u2)) /
			(dfdP(P0, p1, rho1) + dfdP(P0, p2, rho2));*/
		P0 = P;
		P = P0 - dP * (f(P0, p1, rho1) + f(P0, p2, rho2) - (u1 - u2)) /
			(f(P0 + dP, p1, rho1) + f(P0 + dP, p2, rho2) - (f(P0, p1, rho1) + f(P0, p2, rho2)));
		num_iter++;
		if (num_iter > max_iter) {
			printf("Number of iterations is greater than\n\
				maximum number of iterations.\n\
				I'm sorry...\n\
				But I don't find P.\n\
				Stop computations.\n");
			exit(1);
		}
	} while (fabs(P0 - P) > eps && fabs(F(P, p1, rho1, p2, rho2)) > eps);

	if (P <= 0.0) {
		printf("I'm sorry...\n\
			But I don't find P.\n\
			Stop computations.\n");
		exit(1);
	}

	U = 0.5 * (u1 + u2 + f(P, p2, rho2) - f(P, p1, rho1));
	printf("P = %E\tF(P) = %E\tU = %E\n",
		P, F(P, p1, rho1, p2, rho2), U);

	/* left hand --------------------------------------------------*/
	if (U > xi) {
		/* left shock wave ----------------------------------------*/
		if (P >= p1) {
			m = sqrt(rho1 / 2.0 * (P * (gamma + 1.0) + p1 * (gamma - 1.0)));
			W1 = u1 - m / rho1;
			if (xi > W1) {
				R = rho1 * m / (m - (u1 - U) * rho1);
				*rho = R;
				*u = U;
				*v = v1;
				*w = w1;
				*p = P;
			}
			else {
				*rho = rho1;
				*u = u1;
				*v = v1;
				*w = w1;
				*p = p1;
			}
		}
		/* end of left shock wave ---------------------------------*/

		/* left rarefaction wave ----------------------------------*/
		else {
			W1 = u1 - c1;
			ca = c1 + (gamma - 1.0) / 2.0 * (u1 - U);
			Wa1 = U - ca;
			if (xi > Wa1) {
				R = gamma * P / (ca * ca);
				*rho = R;
				*u = U;
				*v = v1;
				*w = w1;
				*p = P;
			}
			else if (xi < W1) {
				*rho = rho1;
				*u = u1;
				*v = v1;
				*w = w1;
				*p = p1;
			}
			else {
				ca = 2.0 / (gamma + 1.0) * c1 +
					(gamma - 1.0) / (gamma + 1.0) * (u1 - xi);
				rhoa = rho1 * pow(ca / c1, 2.0 / (gamma - 1.0));
				ua = xi + ca;
				pa = p1 * pow(ca / c1, 2.0 * gamma / (gamma - 1.0));
				*rho = rhoa;
				*u = ua;
				*v = v1;
				*w = w1;
				*p = pa;
			}
		}
		/* end of left rarefaction wave ---------------------------*/
	}
	/* end of left hand -------------------------------------------*/

	/* right hand -------------------------------------------------*/
	else {
		/* right shock wave ---------------------------------------*/
		if (P >= p2) {
			m = sqrt(rho2 / 2.0 * (P * (gamma + 1.0) + p2 * (gamma - 1.0)));
			W2 = u2 + m / rho2;
			if (xi < W2) {
				R = rho2 * m / (m + (u2 - U) * rho2);
				*rho = R;
				*u = U;
				*v = v2;
				*w = w2;
				*p = P;
			}
			else {
				*rho = rho2;
				*u = u2;
				*v = v2;
				*w = w2;
				*p = p2;
			}
		}
		/* end of right shock wave --------------------------------*/

		/* right rarefaction wave ---------------------------------*/
		else {
			W2 = u2 + c2;
			ca = c2 - (gamma - 1.0) / 2.0 * (u2 - U);
			Wa2 = U + ca;
			if (xi < Wa2) {
				R = gamma * P / (ca * ca);
				*rho = R;
				*u = U;
				*v = v2;
				*w = w2;
				*p = P;
			}
			else if (xi > W2) {
				*rho = rho2;
				*u = u2;
				*v = v2;
				*w = w2;
				*p = p2;
			}
			else {
				ca = 2.0 / (gamma + 1.0) * c2 -
					(gamma - 1.0) / (gamma + 1.0) * (u2 - xi);
				rhoa = rho2 * pow(ca / c2, 2.0 / (gamma - 1.0));
				ua = xi - ca;
				pa = p2 * pow(ca / c2, 2.0 * gamma / (gamma - 1.0));
				*rho = rhoa;
				*u = ua;
				*v = v2;
				*w = w2;
				*p = pa;
			}
		}
		/* end of right rarefaction wave --------------------------*/
	}
	/* end of right hand ------------------------------------------*/
}


int main()
{
	double rhol, ul, vl, wl, pl, el, rhor, ur, vr, wr, pr, er,
		rho, u, v, w, p, x, t, xi, c1, c2;
	int task;
	FILE* output;

	//task = SOD_PROBLEM;
	//task = HARTEN_HYMAN_PROBLEM;
	//task = LEFT_VACUUM_PROBLEM;
	//task = RIGHT_VACUUM_PROBLEM;
	task = VACUUM_RAREFACTIONS_PROBLEM;
	//task = STANDARD_PROBLEM;
	//task = TANGENTIAL_PROBLEM;

	if (task == SOD_PROBLEM) {
		//		gamma = 1.4;

		rhol = 1.0;
		ul = 0.0;
		vl = 0.0;
		wl = 0.0;
		pl = 1.0;
		el = (gamma - 1) * pl + rhol * ul * ul * 0.5;

		rhor = 1.0;
		ur = 0.0;
		vr = 0.0;
		wr = 0.0;
		pr = 0.5;
		er = (gamma - 1) * pr + rhor * ur * ur * 0.5;

		t = 0.1;
	}

	if (task == HARTEN_HYMAN_PROBLEM) {
		//		gamma = 1.4;

		rhol = 0.445;
		ul = 0.311;
		vl = 0.0;
		wl = 0.0;
		el = 8.928;
		pl = (gamma - 1.0) * (el - 0.5 * rhol * (ul * ul + vl * vl + wl * wl));

		rhor = 0.5;
		ur = 0.0;
		vr = 0.0;
		wr = 0.0;
		er = 1.4275;
		pr = (gamma - 1.0) * (er - 0.5 * rhor * (ur * ur + vr * vr + wr * wr));

		t = 0.5;
	}

	if (task == LEFT_VACUUM_PROBLEM) {
		//		gamma = 5.0/3.0;

		rhol = 0.0;
		ul = 0.0;
		vl = 0.0;
		wl = 0.0;
		pl = 0.0;

		rhor = 1.0;
		ur = 0.0;
		vr = 0.0;
		wr = 0.0;
		pr = 1.0;

		t = 0.2;
	}

	if (task == RIGHT_VACUUM_PROBLEM) {
		//		gamma = 5.0/3.0;

		rhol = 1.0;
		ul = 0.0;
		vl = 0.0;
		wl = 0.0;
		pl = 1.0;

		rhor = 0.0;
		ur = 0.0;
		vr = 0.0;
		wr = 0.0;
		pr = 0.0;

		t = 0.2;
	}

	if (task == VACUUM_PROBLEM) {
		//		gamma = 5.0/3.0;

		rhol = 0.0;
		ul = 0.0;
		vl = 0.0;
		wl = 0.0;
		pl = 0.0;

		rhor = 0.0;
		ur = 0.0;
		vr = 0.0;
		wr = 0.0;
		pr = 0.0;

		t = 0.2;
	}

	if (task == VACUUM_RAREFACTIONS_PROBLEM) {
		//		gamma = 5.0/3.0;

		rhol = 1.0;
		ul = -10.0;
		vl = 0.0;
		wl = 0.0;
		pl = 1.0;

		rhor = 1.0;
		ur = 10.0;
		vr = 0.0;
		wr = 0.0;
		pr = 1.0;

		t = 0.5;
	}

	if (task == STANDARD_PROBLEM) {
		//		gamma = 5.0/3.0;

		rhol = 1.0;
		ul = 0.0;
		vl = 0.0;
		wl = 0.0;
		pl = 1.0;

		rhor = 1.0;
		ur = 0.0;
		vr = 0.0;
		wr = 0.0;
		pr = 0.1;

		t = 0.5;
	}

	if (task == TANGENTIAL_PROBLEM) {
		//		gamma = 5.0/3.0;

		rhol = 2.0;
		ul = 1.0;
		vl = 0.0;
		wl = 0.0;
		pl = 5.0;

		rhor = 4.0;
		ur = 1.0;
		vr = 0.0;
		wr = 0.0;
		pr = 5.0;

		t = 0.5;
	}

	c1 = sqrt(gamma * pl / rhol);
	c2 = sqrt(gamma * pr / rhor);

	if ((ul - ur) < (-2.0 / (gamma - 1.0) * (c1 + c2))) {
		printf("solution not exist\n");
	}
	else {
		printf("solution exist\n");
	}

	output = fopen("Riemann_solver.dat", "w");

	for (x = -1.0; x <= 1.0; x += 0.005) {
		xi = x / t;
		Riemann_solver(xi, rhol, ul, vl, wl, pl, rhor, ur, vr, wr, pr, &rho, &u, &v, &w, &p);

		double e228 = ((gamma - 1) * p + rho * u * u * 0.5);
		fprintf(output, "%lf\t %lf\t %lf\t %lf\t %lf\n", x, rho, u, e228, p);
	}

	fclose(output);

	return 0;
}
