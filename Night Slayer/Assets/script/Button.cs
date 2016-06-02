using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour {

//	public string levelToLoad;
//	public bool QuitButton;

	public void QuitGame(bool QuitButton){

		if (QuitButton) {

		
			Debug.Log ("Quit the Game");
			Application.Quit ();

		}
	}

	public void OnMouseDown(string levelToLoad){


		Debug.Log (levelToLoad);
			SceneManager.LoadScene (levelToLoad);
		
	}




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
