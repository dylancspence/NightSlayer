using UnityEngine;
using System.Collections;

public class cross : MonoBehaviour {

	//public GameObject exp;
	public Rigidbody exp;
	public float maxforce = 0;

		void OnTriggerEnter(Collider other){

			if (other.gameObject.CompareTag ("laser")) {
				print ("Both object collided");
			//GameObject go = Instantiate(Resources.Load("exp")) as GameObject;
			//go.transform.position = Vector3.one;
			Rigidbody tempBullet = Instantiate(exp, transform.position, transform.rotation)as Rigidbody;


			tempBullet.velocity = transform.forward * maxforce;
	
				Destroy (other.gameObject);
				Destroy (gameObject);
	
			}
	
		}

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
