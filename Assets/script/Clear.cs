using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour {
	public ParticleSystem clearEffect;
//	public GameObject clearEffect;
	public GameObject clear;
	void Start(){
		clearEffect.enableEmission = false;

	}

	void Update(){
		if (CountTrigger.count==20) {
			Debug.Log ("gameclear" + CountTrigger.count);
		//	Instantiate (clearEffect,clear.transform.position, clear.transform.rotation);
			clearEffect.transform.position=clear.transform.position;
			clearEffect.enableEmission=true;

		}
	}
}
