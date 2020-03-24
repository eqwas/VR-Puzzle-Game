using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public float xRate=0f;
	public float yRate=0f;
	public float zRate=0f;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (xRate, yRate, zRate) * Time.deltaTime);
		
	}
}
