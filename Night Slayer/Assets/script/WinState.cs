using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WinState : MonoBehaviour {

	public string levelToLoad;

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("C")) {

			if (KeySlot.key == 5) {
				print ("You Have All Five Keys");
				SceneManager.LoadScene (levelToLoad);
			}
			else 
				print ("You Don't Have All Five Keys");


		}

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
