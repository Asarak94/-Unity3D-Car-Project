using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOUND1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
          //GET JOYSTICK BUTTON CONTROL
		if (Input.GetButton ("SOUND1")) {
			AudioSource audio=GetComponent<AudioSource>();//GET MP3 AUDIO SOURCE
			audio.Play ();



		}
	}
}
