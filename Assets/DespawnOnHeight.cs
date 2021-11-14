using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		GameObject Character = GameObject.Find("FPSController");

		if (Character.transform.position.y < 0)
		{
			// set level count to 0
			LevelGenerator.levelNum = 0;
			SceneManager.LoadScene("GameOver");
		}

	}
}
