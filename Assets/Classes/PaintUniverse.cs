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
    GameObject Cam;
    GameObject ballPower;
    public int fallCount;


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
		Cam = GameObject.Find("FreeLookCameraRig");
        fallCount = 0;

	}

	/**
    	If the token is collected then we launch the UI sending the player back to the home scene

	@params col - the collision that is detected

	*/
	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "paintToken" && once == 0) 
		{
            completedPaint = true;
			once = 1;
			Debug.Log("Paint Token Touched");
			tokenUIPaint.SetActive(true);

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
            if(personController.activeSelf == false)
            {
                fallCount = 1;
                ballPower = Instantiate(Resources.Load("ballPower") as GameObject);


			}
			Debug.Log("Player has fallen off paint");
            player.GetComponent<Player>().ChangeBackToPlayer();
            personController.transform.position = new Vector3(0f, 0f, 0f);
			player.transform.position = new Vector3(0f, 2f, 0f);
			Cam.transform.position = new Vector3(-200f, 2f, 0f);
			
		}


			
		
	}
}

