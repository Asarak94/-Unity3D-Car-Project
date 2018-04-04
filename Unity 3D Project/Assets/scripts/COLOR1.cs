
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class COLOR1 : MonoBehaviour, IVirtualButtonEventHandler{
	private GameObject VBButtonObject;
	private GameObject car;



	public Color32 d = new Color32 (159,69,37,255);




	void Start () {
		VBButtonObject = GameObject.Find("trunk");
		VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		car = GameObject.Find("car");


	}



	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {

		GetComponent<MeshRenderer> ().material.color=Color.yellow; ;


	}



	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){

		GetComponent<MeshRenderer> ().material.color =d;

	}
}