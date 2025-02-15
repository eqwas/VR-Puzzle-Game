﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadGesture : MonoBehaviour {

	public bool isFacingDown = false;
	public bool isMovingDown=false;
	private float sweepRate=100.0f;
	private float previousCameraAngle;
	// Use this for initialization
	void Start(){
		previousCameraAngle = CameraAngleFromGround ();
	}
	// Update is called once per frame
	void Update () {
		isFacingDown = DetectFacingDown ();
		isMovingDown = DetectMovingDown ();
	}
	private bool DetectFacingDown(){
		return (CameraAngleFromGround () < 60.0f);
	}
	private float CameraAngleFromGround(){
		return Vector3.Angle (Vector3.down, Camera.main.transform.rotation * Vector3.forward);
	}
	private bool DetectMovingDown(){
		float angle = CameraAngleFromGround ();
		float deltaAngle = previousCameraAngle - angle;
		float rate = deltaAngle / Time.deltaTime;
		previousCameraAngle = angle;
		return (rate >= sweepRate);
	}
}
