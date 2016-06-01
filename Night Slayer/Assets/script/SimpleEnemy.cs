using UnityEngine;
using System.Collections;

public class SimpleEnemy : MonoBehaviour {

	public  Transform playerPos;
	public float attackDistance = 20 ;
    float chaseDistance ;
	float minRate = 150 , maxRate = 200;


	public float mySpeed = 10 ;
	public float dist;

	float attackTime = 2.0f;
	public float attackRate = 10;

	public AudioClip bite;

	// Use this for initialization
	void Start () {
		playerPos = GameObject.FindWithTag ("C").transform;
		chaseDistance = Random.Range(minRate, maxRate);
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (playerPos.position, transform.position);
		if (dist < chaseDistance) {
			transform.LookAt (playerPos);
			transform.position += transform.forward * mySpeed * Time.deltaTime;

		}

		if (dist < attackDistance) {

			if (Time.time > attackTime) {

					GameObject.FindWithTag("C").SendMessage("LoseHealth",5);
				    AudioSource.PlayClipAtPoint (bite, transform.position);
					attackTime = Time.time + attackRate;
				//Debug.Log("crunch");

			}

	
		}
	}
}
