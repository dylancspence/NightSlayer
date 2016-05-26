using UnityEngine;
using System.Collections;

public class Skull : MonoBehaviour {

	public Transform myTarget;

	public float attackDistance, minAttack, maxAttack;

	public Transform firePiont; 

	public float fireRate;

	public Rigidbody laser;
	public float fireTime = 0.0f;

	public float minRate, maxRate;

	public float maxForce;

	public float skullHealth = 15;

	public Rigidbody exp;
	public float maxforce = 0;


	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("cross")) {
			//print ("Skullman is in pain");
			skullHealth = skullHealth - 5;
			Destroy (other.gameObject);

		}

	}


	// Use this for initialization
	void Start () {
		myTarget = GameObject.FindWithTag("Player").transform;

		attackDistance = Random.Range(minAttack, maxAttack);
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (myTarget.position, transform.position);

		if (dist <= attackDistance) {
			//print ("skull foung player");
			//	GetComponent<SmoothLookAt>().enabled=true;
			if(Time.time >= fireTime){
				Rigidbody tempBullet = Instantiate(laser, firePiont.position, firePiont.rotation) as Rigidbody;
				//print ("skull fire laser");
				tempBullet.velocity = transform.forward * maxForce;
				fireRate = Random.Range(minRate, maxRate);
				fireTime = Time.time + fireRate;
			}


		} else {
			//GetComponent<SmoothLookAt>().enabled=true;
		}

		if (skullHealth == 0) {
			Rigidbody tempBullet = Instantiate(exp, transform.position, transform.rotation)as Rigidbody;

			//print ("No!!! Skullman!!!");
			tempBullet.velocity = transform.forward * maxforce;
			Destroy (gameObject);


		}
	
	}
}
