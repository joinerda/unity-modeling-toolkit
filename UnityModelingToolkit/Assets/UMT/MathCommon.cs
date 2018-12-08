using UnityEngine;
using System.Collections;

public class MathCommon {

	public static float [] linspace(float min, float max, int n) {
		float[] rv = new float[n];
		rv [0] = min;
		rv [n - 1] = max;
		float step = (max - min) / (float)(n - 1);
		for (int i = 0; i < n - 1; i++)
			rv [i] = min + (float)i * step;
		return rv;
	}

	public static double [] linspace(double min, double max, int n) {
		double[] rv = new double[n];
		rv [0] = min;
		rv [n - 1] = max;
		double step = (max - min) / (double)(n - 1);
		for (int i = 0; i < n - 1; i++)
			rv [i] = min + (double)i * step;
		return rv;
	}
}
