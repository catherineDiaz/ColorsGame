using System.Collections;
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
    GameObject tokenUIPaint;
	int once = 0;
    public bool completedPaint;
    GameObject ball;




	/**
    	Initializes the Paint Universe object

	*/
	void Start () {


		playerFollow = GameObject.Find("PlayerFollow");
		ballFollow = GameObject.Find("BallFollow");
		personController = GameObject.Find("ThirdPersonController");
        personController.SetActive(true);
		paintToken = GameObject.Find("paintToken");
		player = GameObject.Find("Player");
        tokenUIPaint = GameObject.Find("tokenUIPaint");
        tokenUIPaint.SetActive(false);
        completedPaint = false;
        ball = GameObject.Find("RollerBall");
        //ball.SetActive(false);
		
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
			Debug.Log("Paint Token Touched");
			tokenUIPaint.SetActive(true);
            completedPaint = true;

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

		if(playerFollow.transform.position.y < -500)
		{
			UI fallUI = GameObject.Find("UIController").GetComponent<UI>();
			player.GetComponent<Player>().ChangeBackToPlayer();
			fallUI.YesTravelNowPaintClick();
		}


			
		
	}
}

