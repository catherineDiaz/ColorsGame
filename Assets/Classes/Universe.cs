<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:71f7b44a2417085e25a1c97677bc10020da4527a2dc26cc62be2c604fa0d185a
size 1371
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Universe : MonoBehaviour {

	// Use this for initialization

	public string sceneName;
	private int once;
	private GameObject player;


	void Start () {

		player = GameObject.Find("Player");

		
	}


	public void loadSceneObjects(Scene scene)
	{
		if(sceneName == "PaintUniverse")
		{
			SceneManager.MoveGameObjectToScene(player, scene);
			player.transform.position = new Vector3(-31.6f, 0.26f, 45);
			//player.transform.rotation = new Quaternion.Euler(0,141.95f,0);
			//Resources.load course
		}
		
	}


	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "PortalToPaint" && once == 0) 
		{
			once = 1;
			Debug.Log("Portal Has Been Touched");
			UI travelUI = GameObject.Find("UIController").GetComponent<UI>();
			travelUI.TravelUI();

		}

	}



	
	// Update is called once per frame
	void Update () {
		
	}
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
