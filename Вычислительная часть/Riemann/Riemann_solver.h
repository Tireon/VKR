#ifndef __RIEMANN_SOLVER__
#define __RIEMANN_SOLVER__

#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <float.h>

double f(double, double, double);
double dfdP(double, double, double);
double F(double, double, double, double, double);
void Riemann_solver(double,
	double, double, double, double, double,
	double, double, double, double, double,
	double*, double*, double*, double*, double*);

#define gamma 1.4
#define eps 1.0E-6
#define max_iter 32

#endif /* __RIEMANN_SOLVER__ */
