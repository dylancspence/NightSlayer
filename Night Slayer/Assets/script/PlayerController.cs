using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public float speed;
//
//	private Rigidbody rb;

	//public float speed1 = 10.0F;
	public float rotateSpeed = 3.0F;


	// Use this for initialization
	void Start () {
//		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//
//		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);





			


		CharacterController controller = GetComponent<CharacterController>();
		transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		float curSpeed = speed * Input.GetAxis("Vertical");
		controller.SimpleMove(forward * curSpeed);

	}
}
