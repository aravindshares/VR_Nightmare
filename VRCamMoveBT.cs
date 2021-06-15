﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class VRCamMoveBT : MonoBehaviour {

	public float speed = 3.0F;
	private CharacterController myCharCon;
	private Transform vrCam;

	private bool moveStart;

	// Use this for initialization
	void Start () {

		myCharCon = GetComponent<CharacterController>();
		vrCam = Camera.main.transform;


		
	}
	
	// Update is called once per frame
	void Update () {

		myCharCon.SimpleMove(speed * vrCam.TransformDirection(Vector3.forward * -Input.GetAxis("Horizontal") + Vector3.right * Input.GetAxis("Vertical")));
		
	}
}
