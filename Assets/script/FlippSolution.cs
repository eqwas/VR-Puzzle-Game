using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippSolution : MonoBehaviour {
	private HeadGesture gesture;

	public GameObject Soulution;

	//	public GameObject marking;

	private bool isOpen= true;
	private Vector3 StartRotaion;
	private Vector3 StartPosition;
	private int count =0;


	// Use this for initialization
	void Start () {
		gesture = GetComponent<HeadGesture> ();



		StartRotaion = Soulution.transform.eulerAngles;
		StartPosition = Soulution.transform.position;

		SetSolution ();
	}

	// Update is called once per frame
	void Update () {
		if (gesture.isFacingDown ) {
			count = 1;
		} 
		if (count == 1 && !gesture.isFacingDown) {
			SetSolution ();

		}

}
	private void SetSolution(){
		if (!isOpen) {
			Soulution.transform.eulerAngles = StartRotaion;
			Soulution.transform.position = StartPosition;

			isOpen = true;
			count = 0;

		} else if (isOpen) {
			Soulution.transform.position=new Vector3(StartPosition.x,StartPosition.y-0.7f,StartPosition.z);
			Soulution.transform.eulerAngles = new Vector3 (StartRotaion.x, StartRotaion.y, 180.0f);
			isOpen = false;
			count = 0;

			
		}

	}



}