using System.Collections;
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
		}
		
	}


	void OnCollisionEnter (Collision col)
	{
        UI travelUI = GameObject.Find("UIController").GetComponent<UI>();

        if (gameObject.name == "PortalToPaint(Clone)" && once == 0) 
		{
			once = 1;
			Debug.Log("Portal Has Been Touched");
            travelUI.TravelUI("PortalToPaint");

		}
		if (gameObject.name == "PortalToWaterColor(Clone)" && once == 0)
		{
			once = 1;
			Debug.Log("Water Color Portal Has Been Touched");
			travelUI.TravelUI("PortalToWaterColor");

		}
		if (gameObject.name == "PortalToInk(Clone)" && once == 0)
		{
			once = 1;
			Debug.Log("Ink Portal Has Been Touched");
			travelUI.TravelUI("PortalToInk");

		}

	}



	
	// Update is called once per frame
	void Update () {





		
	}
}

