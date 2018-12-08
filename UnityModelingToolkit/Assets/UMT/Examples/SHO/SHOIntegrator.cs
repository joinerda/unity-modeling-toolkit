using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHOIntegrator : Integrator {

	public double [] x;
	public double k;
	public double m;

	public void setIC(double xin, double vin, double k, double m) {
		Init (2); // Init should be called in Start or Awake
		x = new double[2];
		x [0] = xin;
		x [1] = vin;
		this.k = k;
		this.m = m;
	}

	public override void RatesOfChange (double[] x, double[] xdot, double t)
	{
		xdot [0] = x [1];
		xdot [1] = -k / m * x [0];
	}
		
}
