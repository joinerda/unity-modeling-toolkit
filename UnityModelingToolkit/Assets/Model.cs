using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;

public class Model : MonoBehaviour {

	SHOModel theModel;
	double t=0;
	double h = 0.01;
	public GameObject thingToMove;

	void Start() {
		theModel = new SHOModel ();
		theModel.setIC (1, 0, 1, 1);
		Debug.Log (theModel.x[0]);
	}

	// Update is called once per frame
	void Update () {
		t = theModel.RK4Step (theModel.x, t, h);
		Vector3 pos = thingToMove.transform.position;
		pos.x = (float)theModel.x [0];
		thingToMove.transform.position = pos;
	}
		
}

