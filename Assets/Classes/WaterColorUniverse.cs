using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterColorUniverse : MonoBehaviour {
	GameObject playerFollow;
	GameObject personController;
	GameObject player;
	int once = 0;
	GameObject maze;
    GameObject tokenUIWaterColor;
    public bool completedWaterColor;
    GameObject ball;




	/**
    	Initializes the WaterColor Universe object

	*/
	void Start () {
		maze = GameObject.Find("waterColorMaze");
		playerFollow = GameObject.Find("PlayerFollow");
		personController = GameObject.Find("ThirdPersonController");
		player = GameObject.Find("Player");
        tokenUIWaterColor = GameObject.Find("tokenUIWaterColor");
        tokenUIWaterColor.SetActive(false);
        completedWaterColor = false;


	}
	/**
	    If the token is collected then we launch the UI sending the player back to the home scene

        @params col - the collision that is detected

    */
	void OnCollisionEnter(Collision col)
	{
		if (gameObject.name == "waterColorToken" && once == 0)
		{
			once = 1;
			Debug.Log("Water Color Token Touched");
            tokenUIWaterColor.SetActive(true);
            completedWaterColor = true;


		}

	}



    	
	// Update is called once per frame
	void Update () {


	    playerFollow.transform.position = personController.transform.position;
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 20);
        gameObject.transform.Rotate(Vector3.right * Time.deltaTime * 15);

		

		if (playerFollow.transform.position.y < -500)
		{
			UI fallUI = GameObject.Find("UIController").GetComponent<UI>();
			player.GetComponent<Player>().ChangeBackToPlayer();
            fallUI.YesTravelNowWaterColorClick();
		}
		
	}
}

