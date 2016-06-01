using UnityEngine;
using System.Collections;

public class BatEnemy : MonoBehaviour {

	public  GameObject playerPos;
	  NavMeshAgent agent;
	public GameObject[] patrolPoints;
	int currentPoint = 0;
	public string state = "patrol";
	public float playerDistance;

//	public float mySpeed;
//	public float rotateSpeed = 3.0F;
//	public float minSpeed , maxSpeed;

	public float attackDistance;
	public float chaseDistance;
	public float attackRate;

	//float attackTime = 0.0f;

	// Use this for initialization
	void Start () {
	//	playerPos = GameObject.FindWithTag ("C").transform;
//		agent.destination = patrolPoints[currentPoint].transform.position;

		agent = GetComponent<NavMeshAgent> ();
//		mySpeed = Random.Range (minSpeed, maxSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		playerDistance = Vector3.Distance (transform.position, playerPos.transform.position);
		//Debug.Log (playerDistance);
		if (state == "patrol") {
			
			if (playerDistance < chaseDistance) {

				state = "chase";

				//transform.LookAt (playerPos);
				agent.destination = playerPos.transform.position;



				agent.speed = 4;



			}


			if (agent.remainingDistance < .01) {
				if (currentPoint < (patrolPoints.Length - 1)) {

					currentPoint++;


				} else {

					currentPoint = 0;


				}
				//agent.destination = patrolPoints [currentPoint].transform.position;
				agent.destination = playerPos.transform.position;
			}

				



		} 

		if (state == "chase") {

			agent.destination = playerPos.transform.position;



			if (playerDistance < attackDistance) {

				state = "attack";


				//agent.Stop ();

			}



		} 
		if (state == "attack") {







		}

	}
}
