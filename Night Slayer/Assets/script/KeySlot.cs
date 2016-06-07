using UnityEngine;
using System.Collections;

public class KeySlot : MonoBehaviour {
	//public GameObject hud;

	//public Canvas hud;
	public GameObject k0, k1, k2,k3,k4,k5;
	public AudioClip bing;
	public static float  key;
	//public Collider o;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("key")) {
			print ("key was been added");
			key++;
			if (key == 5) {
				print ("You Got The Final Key");
			}
			AudioSource.PlayClipAtPoint (bing, transform.position);
			other.gameObject.SetActive (false);

		}

	}
	// Use this for initialization
	void Start () {
		
		key = 0;

	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown ("space")) {
//			print ("space key was pressed");
//			key++;
//		}



		if (key == 0) {
			//print ("key 0");
			k0.SetActive(true);
			k1.SetActive(false);
			k2.SetActive(false);
			k3.SetActive(false);
			k4.SetActive(false);
			k5.SetActive(false);
		}
		else if (key == 1) {
			//print ("key 1");
			k0.SetActive(false);
			k1.SetActive(true);
			k2.SetActive(false);
			k3.SetActive(false);
			k4.SetActive(false);
			k5.SetActive(false);
		}
		if (key == 2) {
			k0.SetActive(false);
			k1.SetActive(false);
			k2.SetActive(true);
			k3.SetActive(false);
			k4.SetActive(false);
			k5.SetActive(false);

		}
		if (key == 3) {
			k0.SetActive(false);
			k1.SetActive(false);
			k2.SetActive(false);
			k3.SetActive(true);
			k4.SetActive(false);
			k5.SetActive(false);

		}
		if (key == 4) {
			k0.SetActive(false);
			k1.SetActive(false);
			k2.SetActive(false);
			k3.SetActive(false);
			k4.SetActive(true);
			k5.SetActive(false);

		}
		if (key == 5) {
			k0.SetActive(false);
			k1.SetActive(false);
			k2.SetActive(false);
			k3.SetActive(false);
			k4.SetActive(false);
			k5.SetActive(true);

		}

	
	}
}
