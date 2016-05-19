using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoSlot : MonoBehaviour {

	public Text ammo;
	public  int num;
	public  int textnum;



	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("cross")) {
			print ("Ammo has been added");
			num = num + 11;
			textnum = num;
			ammo.text = textnum.ToString();
			other.gameObject.SetActive (false);

		}

	}

	// Use this for initialization
	void Start () {
		num = 20;
		textnum = num;
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown ("space") && num > 0) {
//			print ("space key was pressed for Ammo");
//			num = num - 1;
//			textnum = num;
//			ammo.text = textnum.ToString();
//		}
		if (num > 0) {
			PlayerThrow.ready = true;
		}
		if (num <= 0) {
			PlayerThrow.ready = false;
//			num = 0;
//			textnum = num;
//			ammo.text = textnum.ToString();
		}


		if (Input.GetKeyDown ("a") && num > 0) {
			print ("Player Fire Ammo");
			num = num - 1;
			textnum = num;
			ammo.text = textnum.ToString();
		}



	}
}
