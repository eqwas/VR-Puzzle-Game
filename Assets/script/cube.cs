using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {
   //	private CountTrigger c = new global::countTrigger ();

	void OnTriggerEnter(Collider get){
		if (get.gameObject.tag=="trigger") {
			//c.upCount ();
			CountTrigger.count++;
			//Debug.Log ("check"+CountTrigger.count);

		}
		
	}

	void OnTriggerExit(Collider get){
		if (get.CompareTag("trigger")) {
			CountTrigger.count--;
		//	Debug.Log ("uncheck"+CountTrigger.count);

		}

	}

	
}
