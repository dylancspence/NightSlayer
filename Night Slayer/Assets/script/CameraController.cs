using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	//int look = 1;


	public float rotateSpeed = 3.0F;


	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown ("q")) {
//			print ("Player a to look around");
//			look = 0;
//		}

		transform.position = player.transform.position + offset;
//		if (look == 1) {
//			transform.Rotate (0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
//		}
	}
}
