<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:d748b90321f053352827457b340cb9e30c76cefa5ad78cead8b9cf41579d4f09
size 1207
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterColorUniverse : MonoBehaviour {
	GameObject playerFollow;
	GameObject personController;
	GameObject player;
	int once = 0;
	GameObject maze;




	/**
    	Initializes the WaterColor Universe object

	*/
	void Start () {
		maze = GameObject.Find("waterColorMaze");
		playerFollow = GameObject.Find("PlayerFollow");
		personController = GameObject.Find("ThirdPersonController");
		player = GameObject.Find("Player");


	}



	public void xRayVision()
	{

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
