
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class sound : MonoBehaviour, IVirtualButtonEventHandler{
	private GameObject VBButtonObject;
	private GameObject car;



	void Start () {
		VBButtonObject = GameObject.Find("sound");
		VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		car = GameObject.Find("car");


	}



	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {


		AudioSource audio=GetComponent<AudioSource>();
		audio.Play();

	}




	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		AudioSource audio=GetComponent<AudioSource>();
		audio.Stop();


	}
}