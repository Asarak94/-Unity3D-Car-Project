﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class color : MonoBehaviour, IVirtualButtonEventHandler{
	private GameObject VBButtonObject;
	private GameObject car;
	//public Color c;


	public Color32 C = new Color32 (159,69,37,255);




	void Start () {
		VBButtonObject = GameObject.Find("color");
		VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		car = GameObject.Find("car");


	}



	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {

		GetComponent<MeshRenderer> ().material.color=Color.blue; ;
		 

	}



	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){

		GetComponent<MeshRenderer> ().material.color = C;

	}
}