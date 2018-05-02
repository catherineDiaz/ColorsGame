using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InkUniverse : MonoBehaviour {

	GameObject playerFollow;
	GameObject personController;
	GameObject player;
	public bool completedInk;

	GameObject inkPiece1;
	GameObject inkPiece2;
	GameObject inkPiece3;
	GameObject inkPiece4;

	public GameObject inkPiecePic1;
	public GameObject inkPiecePic2;
	public GameObject inkPiecePic3;
	public GameObject inkPiecePic4;


	public int inkPieceCount;
	public GameObject inkOf4;
    GameObject tokenUIInk;
    int once = 0;
    GameObject Cam;


	/**
        Initializes the Ink Universe object

    */
	void Start()
	{


		playerFollow = GameObject.Find("PlayerFollow");
		personController = GameObject.Find("ThirdPersonController");
		personController.SetActive(true);
		player = GameObject.Find("Player");
		completedInk = false;

		tokenUIInk = GameObject.Find("tokenUIInk");
		tokenUIInk.SetActive(false);
		completedInk = false;

		inkPiece1 = GameObject.Find("inkPiece1");
		inkPiece2 = GameObject.Find("inkPiece2");
		inkPiece3 = GameObject.Find("inkPiece3");
		inkPiece4 = GameObject.Find("inkPiece4");

        inkPieceCount = 0;

		Cam = GameObject.Find("FreeLookCameraRig");



		Debug.Log("From Ink");
	}

	/**
	    Update count of the number of ink pieces the player has collected 

    */
	public int incrementInkPiece()
    {
        return inkPieceCount++;
    }


	/**
        Update the camera following position, if the object is currently the person then have the camera 
        follow the person, if the person transforms into the ball then follow it 

    */
	void Update()
	{


		playerFollow.transform.position = personController.transform.position;
        playerFollow.transform.rotation = personController.transform.rotation;
		

		if (playerFollow.transform.position.y < -100)
		{
			Debug.Log("Player has fallen off Ink");
			player.transform.position = new Vector3(0f, 0f, 0f);
			personController.transform.position = new Vector3(0f, 0f, 0f);
			Cam.transform.position = new Vector3(0f, 0f, -200f);

		}

        if(inkPieceCount == 4 && once == 0)
        {
			tokenUIInk.SetActive(true);
			completedInk = true;
            once = 1;
        }




	}
}

