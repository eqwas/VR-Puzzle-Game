using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTrigger : MonoBehaviour {
	public static int count;
	void Awake(){
		count = 0;

	}

	public void upCount(){
		count++;
	}
	public void downCount(){
		count--;
	}
	public int returnCount(){
		return count;
	}



}
