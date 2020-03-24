using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabCube : MonoBehaviour {
	private GameObject grabtarget;
	public GameObject targetPositon;
	public GameObject hand;
	private Vector3 hp;
//	private bool onoff;

	public float selectTime=1.0f;
	public Image Loading;
	private float countDown;
	private onoff state=new global::onoff();
	private CountTrigger c = new CountTrigger ();



	void Start () {
		state.setoff ();
		countDown = selectTime;
		Loading.fillAmount = 0;
	}


	void Update () {
		Debug.Log (CountTrigger.count);
		Transform camera = Camera.main.transform;
		Ray ray = new Ray (camera.position, camera.rotation * Vector3.forward);
		RaycastHit hit;
		hp = hand.transform.position;

		if (!state.returnstate()) {
			if (Physics.Raycast (ray, out hit) && (hit.collider.gameObject.tag == "grab")) {
				grabtarget = hit.collider.gameObject;
				if (countDown > 0.0f) {
					Loading.fillAmount += selectTime * Time.deltaTime;
					countDown -= Time.deltaTime;

				} else
					state.seton ();
					//onoff = true;

			} else {
				countDown = selectTime;
				Loading.fillAmount = 0.0f;
			}
		} else if (state.returnstate()) {
			if (Input.anyKey) {
				//onoff = false;
				state.setoff();
			} else {
				
				hp.y = 3f; 
		
				grabtarget.transform.position = hp;
				hp.y = 0.5f;
				targetPositon.transform.position = hp;

				countDown = selectTime;
				Loading.fillAmount = 0.0f;

			}	
		}


	}
}
