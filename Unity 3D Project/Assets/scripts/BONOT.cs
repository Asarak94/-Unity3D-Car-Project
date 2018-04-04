
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BONOT : MonoBehaviour, IVirtualButtonEventHandler{
	private GameObject VBButtonObject;
	private GameObject car;
	bool a = false;

	Animator animation;

	void Start () {
		VBButtonObject = GameObject.Find("bonot");
		VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		car = GameObject.Find("car");

		animation = GetComponent<Animator>();
	}



	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		if (!a) {
			animation.SetTrigger ("open bonot");
			a = true;
		}
		if (a) {
			animation.SetTrigger ("open bonot");
			a = true;
		}

	}

	void pauseAnimationEvent1(){
		animation.enabled = false;
	}


	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		animation.enabled = true;

	}
}