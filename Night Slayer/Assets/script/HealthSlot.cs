using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HealthSlot : MonoBehaviour {
	public Text health;
	public Text demo;
	public int num;
	public AudioClip bing;
	public AudioClip hit;

	public string levelToLoad;

	// Use this for initialization
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("health")) {
			print ("Health has been added");
			num = num + 10;
			health.text = num.ToString();
			other.gameObject.SetActive (false);
			AudioSource.PlayClipAtPoint (bing, transform.position);
		}
		if (other.gameObject.CompareTag ("laser")) {
			
			num = num - 10;
			health.text = num.ToString();
			other.gameObject.SetActive (false);
			AudioSource.PlayClipAtPoint (hit, transform.position);
		}


	}
	void Start () {
		num = 100;
		health.text = num.ToString();
	}

	void LoseHealth (int number){
		num = num - number;
		health.text = num.ToString();

	}



	// Update is called once per frame
	void Update () {

		if (num == 0) {
			
			//num = 0;

			print("You're Death");
			SceneManager.LoadScene (levelToLoad);
		}


//		if (Input.GetKeyDown ("space")&& num > 0) {
//			print ("space key was pressed for Health");
//			num = num - 5;
//			health.text = num.ToString();
//			AudioSource.PlayClipAtPoint (hit, transform.position);
//		}
	}
}
