<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:a3066a8e94891849de6951eac1e6d978bb2469b6ecf03380f5f4e6627835fa00
size 965
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;       

	private Vector3 offset;         //offset distance between the player and camera


	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;


	/**
    	Initialize Camera to follow the player where ever it goes

	*/
	void Start () 
	{
		offset = transform.position - player.transform.position;
		offset.y = offset.y + 2;
	}



	/**
    	Update camera location each frame, and use mouse postion to rotate camera 

	*/
	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset 
		transform.position = player.transform.position + offset;
		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");
		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

	}
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
