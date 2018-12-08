using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;

public class SHOModel : TimestepModel {

	SHOIntegrator theIntegrator;
	double t=0;
	double h = 0.01;
	public GameObject thingToMove;

	void Start() {
		theIntegrator = new SHOIntegrator ();
		theIntegrator.setIC (1, 0, 1, 1);
		Debug.Log (theIntegrator.x[0]);

		ModelStart (); // ModelStart should be called on Start or Awake
	}

	public override void TakeStep (float dt) {
		t = theIntegrator.RK4Step (theIntegrator.x, t, h);
	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = thingToMove.transform.position;
		pos.x = (float)theIntegrator.x [0];
		thingToMove.transform.position = pos;
	}
		
}

