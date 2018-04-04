using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATE1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("ROTATE1")) {
			transform.Rotate(0, 0, 500*Time.deltaTime, Space.Self);//ROTATE BY Z AXIS


		}
	}
}
