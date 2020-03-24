using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMark : MonoBehaviour {
	public GameObject ground;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		Transform camera = Camera.main.transform;
		Ray ray;
		RaycastHit[] hits;
		GameObject hitObject;

		Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100.0f);

		ray = new Ray(camera.position, camera.rotation * Vector3.forward * 100.0f);

		hits = Physics.RaycastAll (ray);

		for(int i=0;i<hits.Length;i++){
			RaycastHit hit=hits[i];
			hitObject=hit.collider.gameObject;
			if(hitObject==ground){
				Debug.Log("hit x y z"+hit.point.ToString("f2"));
				transform.position=hit.point;

			}
		}


	}
}
