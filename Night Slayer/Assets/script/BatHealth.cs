using UnityEngine;
using System.Collections;

public class BatHealth : MonoBehaviour {
	public float skullHealth = 10;
	public Rigidbody exp;
	public float maxforce = 0;
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("cross")) {
			print (" pain");
			Destroy (other.gameObject);
			skullHealth = skullHealth - 5;


		}

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (skullHealth <= 0) {
			Rigidbody tempBullet = Instantiate(exp, transform.position, transform.rotation)as Rigidbody;
//
//			//print ("No!!! Skullman!!!");
			tempBullet.velocity = transform.forward * maxforce;
			Destroy (gameObject);


		}
	}
}
