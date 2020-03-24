using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObj : MonoBehaviour {
	public GameObject obj;
	public float startHegiht = 10.0f;
	public int count=0;

	/*
	void start(){
		Vector3 Position = new Vector3 (Random.Range (-4.0f, 4.0f), startHegiht, Random.Range (-4.0f, 4.0f));
		Instantiate (obj, Position, Quaternion.identity);
	}
	*/

	// Update is called once per frame
	void Update () {
	 
	if(Time.time==0.1){
			
			for (int i = 0; i < count; i++) {
				Vector3 Position = new Vector3 (Random.Range (-4.0f, 4.0f), startHegiht, Random.Range (-4.0f, 4.0f));
				Instantiate (obj, Position, Quaternion.identity);
			}

		}
	

	}

}