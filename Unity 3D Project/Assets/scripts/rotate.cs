
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class rotate : MonoBehaviour, IVirtualButtonEventHandler{
	private GameObject VBButtonObject;
	private GameObject car;

	Animator anim;

	void Start () {
		VBButtonObject = GameObject.Find("rotate");
		VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		car = GameObject.Find("car");


	}



	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		//car.transform.Rotate (0,Time.deltaTime * 90,0,Space.World);
		car.transform.Rotate(0, 0, 500*Time.deltaTime, Space.Self);


	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){

	}
}