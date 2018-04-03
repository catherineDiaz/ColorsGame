<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:01fd643ec6fcf3ef0a93f1a534c3e7f45cb216e7be935b329f464a9efae60ff1
size 1435
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Power : MonoBehaviour {

	string powerName_;
	public GameObject ball;
	GameObject person;
	Vector3 position_;
	int once;
	GameObject camera1;
	GameObject camera2;

	public bool isUsingPowerBall;

	/**
    	Initializes Power object, the constructor

	*/
	void Start()
	{
		powerName_ = this.name;
		bool now = false;
		once = 0;
		person = GameObject.Find("ThirdPersonController");
		person.SetActive(true);
		isUsingPowerBall = false;


	}

	/**
    	If a power is touched, apply the power to the player

	*/
	public void ApplyPower()
	{
		if(gameObject.name == "ballPower") // If the object touched was the ball power
		{
			if(SceneManager.GetActiveScene().name == "PaintUniverse")
			{
				GameObject.Find("Player").GetComponent<Player>().isUsingRollerPower = true;	
				
			}


		}
	}

	/**
    	Waiting for collision on the power 3D object in the game, if another game object (the Player)
    	collides with the Power then the UI is initialized and asks the player if they want to use
    	the power now or later

	*/
	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "ballPower" && once == 0) 
		{
			once = 1;
			Debug.Log("Object Touched");
			UI powerUI = GameObject.Find("UIController").GetComponent<UI>();
			powerUI.CollectedPower();

		}

	}



	void Update () {


		
	}
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
