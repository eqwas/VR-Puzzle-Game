using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoff : MonoBehaviour {

	private bool state;
	public void seton(){
		state = true;
	}
	public void setoff(){
		state = false;
	}
	public bool returnstate(){
		return state;
	}
}
