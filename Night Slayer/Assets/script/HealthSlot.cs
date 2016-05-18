using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthSlot : MonoBehaviour {
	public Text health;
	public Text demo;
	public int num;
	// Use this for initialization
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("health")) {
			print ("Health has been added");
			num = num + 10;
			health.text = num.ToString();
			other.gameObject.SetActive (false);

		}

	}
	void Start () {
		num = 100;
		health.text = num.ToString();
	}



	// Update is called once per frame
	void Update () {

		if (num <= 0) {
			
			num = 0;

			print("You're Death");

		}


		if (Input.GetKeyDown ("space")) {
			print ("space key was pressed for Health");
			num = num - 5;
			health.text = num.ToString();
		}
	}
}
