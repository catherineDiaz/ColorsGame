using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningAndClosingScene : MonoBehaviour {

	/**
	    Initializes the OpenClosing object

    */
	void Start () {

        if(SceneManager.GetActiveScene().name == "OpeningScene")
        {
            SceneManager.LoadScene("HomeLand", LoadSceneMode.Single);
        }
        else
        {
			Debug.Log("GoodBye!");
			Application.Quit();
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
