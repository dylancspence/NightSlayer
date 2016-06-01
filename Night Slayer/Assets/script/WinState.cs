using UnityEngine;
using System.Collections;

public class WinState : MonoBehaviour {


	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("C")) {

			if (KeySlot.key == 5) {
				print ("You Have All Five Keys");

			}
			else 
				print ("You Don't Have All Five Keys");


		}

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
