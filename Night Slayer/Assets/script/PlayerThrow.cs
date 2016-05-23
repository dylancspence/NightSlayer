using UnityEngine;
using System.Collections;

public class PlayerThrow : MonoBehaviour {

	//for throw cross
	public Rigidbody bullet;
	public float maxforce;
	public float fireRate;
	float fireTime = 0.0f;
	public static int givenum;
	public static bool ready = false;


	// Use this for initialization
	void Start () {
		givenum = 20;
	}
	
	// Update is called once per frame
	void Update () {
		//throwing cross
		if (ready == true && Input.GetKeyDown ("q")) {

			if((Time.time > fireTime)){



				Debug.Log("player fires");

				Rigidbody tempBullet = Instantiate(bullet, transform.position, transform.rotation)as Rigidbody;


				tempBullet.velocity = transform.forward * maxforce;

				fireTime = Time.time + fireRate;


				//AmmoSlot.num= num;
			}
		}
	}
}
