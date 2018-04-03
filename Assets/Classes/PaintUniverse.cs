<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:df873455ece2da33e4d89f4c3044524f69acebb2e7cb43e81d354fc228625f2d
size 1756
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintUniverse : MonoBehaviour {

	GameObject playerFollow;
	GameObject personController;
	GameObject ballFollow;
	GameObject rollerBall;
	GameObject paintToken;
	GameObject player;
	int once = 0;




	/**
    	Initializes the Paint Universe object

	*/
	void Start () {


		playerFollow = GameObject.Find("PlayerFollow");
		ballFollow = GameObject.Find("BallFollow");
		personController = GameObject.Find("ThirdPersonController");
		paintToken = GameObject.Find("paintToken");
		player = GameObject.Find("Player");

		
	}



	/**
    	If the token is collected then we launch the UI sending the player back to the home scene

	@params col - the collision that is detected

	*/
	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "paintToken" && once == 0) 
		{
			once = 1;
			Debug.Log("Token Touched");
			UI tokenUIPaint = GameObject.Find("UIController").GetComponent<UI>();
			tokenUIPaint.TokenUIPaint();

		}

	}

	
	/**
		Update the camera following position, if the object is currently the person then have the camera 
		follow the person, if the person transforms into the ball then follow it 

	*/
	void Update () {
		
		if(personController.activeSelf == false)
		{
			rollerBall = GameObject.Find("RollerBall");
			playerFollow.transform.position = rollerBall.transform.position;
		}
		else
		{
			playerFollow.transform.position = personController.transform.position;
			
		}

		if(playerFollow.transform.position.y < -40)
		{
			UI fallUI = GameObject.Find("UIController").GetComponent<UI>();
			player.GetComponent<Player>().ChangeBackToPlayer();
			fallUI.YesTravelNowClick();
		}


			
		
	}
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
