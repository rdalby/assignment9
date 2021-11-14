using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// gets current scene which will help with redirecting the submit ("enter")
		// depending on if at game over or title scenes 
		Scene CurrentScene = SceneManager.GetActiveScene();

		if (Input.GetAxis("Submit") == 1){
			
			// checks which scene it's on before advancing
			if (CurrentScene.name == "Title") {
				SceneManager.LoadScene("Play");
			}

			else if (CurrentScene.name == "GameOver") 
			{
				SceneManager.LoadScene("Title");
			}
		}
	}
}
