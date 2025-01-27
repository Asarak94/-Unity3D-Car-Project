﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class door : MonoBehaviour, IVirtualButtonEventHandler{
	private GameObject VBButtonObject;
	private GameObject car;

	Animator anim;

	void Start () {
		VBButtonObject = GameObject.Find("door");
		VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		car = GameObject.Find("car");

		anim = GetComponent<Animator>();
	}



	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {

		anim.SetTrigger("open door");

	}

	void pauseAnimationEvent(){
		anim.enabled = false;
	}


	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		anim.enabled = true;

	}
}