using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveTarget : MonoBehaviour {
	public Image Loading;
	private GameObject movetarget;
	public GameObject moveeffect;
	public float selectTime=1f;
	private float countDown;


	void Start () {

		countDown = selectTime;
		Loading.fillAmount = 0;
	}
		
	
	void Update () {
		Transform camera = Camera.main.transform;
		Ray ray = new Ray (camera.position, camera.rotation * Vector3.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit) && (hit.collider.gameObject.tag == "mark")) {
			movetarget = hit.collider.gameObject;
			if (countDown > 0.0f) {
			Loading.fillAmount += selectTime * Time.deltaTime;
				countDown -= Time.deltaTime;
				
			} else {
				Instantiate (moveeffect, movetarget.transform.position, movetarget.transform.rotation);
				Vector3 moveDirection = movetarget.transform.position;
				moveDirection.y = 1.0f;
				transform.position = moveDirection;
				countDown = selectTime;
				Loading.fillAmount = 0.0f;


			}
		

		} else {
			if (countDown < selectTime && countDown > 0 && Loading.fillAmount > 0) {
			countDown = selectTime;
			Loading.fillAmount = 0.0f;
			}
		}
		
	
	}
}
