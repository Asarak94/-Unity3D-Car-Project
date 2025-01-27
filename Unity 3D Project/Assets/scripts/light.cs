﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class light : MonoBehaviour, IVirtualButtonEventHandler{
	private GameObject VBButtonObject;
	private GameObject car;

	public MeshRenderer brakelights;
	public Material brakelightsON;
	public Material brakelightsOFF;

	public MeshRenderer headlights;
	public Material headlightsON;
	public Material headlightsOFF;

	public Light SpotlightRight;
	public Light SpotlightLeft;

	void Start () {
		VBButtonObject = GameObject.Find("light");
		VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		car = GameObject.Find("car");


	}



	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		brakelights.material = brakelightsON;
		headlights.material =headlightsON;
		SpotlightRight.intensity = 15f;
		SpotlightLeft.intensity = 15f;

	}




	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		brakelights.material = brakelightsOFF;
		headlights.material = headlightsOFF;
		SpotlightLeft.intensity = 0f;
		SpotlightRight.intensity = 0f;
	}
}