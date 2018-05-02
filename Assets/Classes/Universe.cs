using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Universe : MonoBehaviour {

	// Use this for initialization

	public string sceneName;
	private int once1;
    private int once2;
    private int once3;
	private GameObject player;

	/**
	    Initializes the Universe object

    */
	void Start () {

		player = GameObject.Find("Player");
        once1 = 0;
        once2 = 0;
        once3 = 0;
		
	}

	/**
	    Load Scene objects for paint

    */
	public void loadSceneObjects(Scene scene)
	{
		if(sceneName == "PaintUniverse")
		{
			SceneManager.MoveGameObjectToScene(player, scene);
			player.transform.position = new Vector3(-31.6f, 0.26f, 45);
		}
		
	}

	/**
        If a portal is touched then launch the UI to Travel

        @params col - the collision that is detected

    */
	void OnCollisionEnter (Collision col)
	{
        UI travelUI = GameObject.Find("UIController").GetComponent<UI>();

        if (gameObject.name == "PortalToPaint(Clone)" && once1 == 0) 
		{
			once1 = 1;
			Debug.Log("Portal Has Been Touched");
            travelUI.TravelUI("PortalToPaint");

		}
		if (gameObject.name == "PortalToWaterColor(Clone)" && once2 == 0)
		{
			once2 = 1;
			Debug.Log("Water Color Portal Has Been Touched");
			travelUI.TravelUI("PortalToWaterColor");

		}
		if (gameObject.name == "PortalToInk(Clone)" && once3 == 0)
		{
			once3 = 1;
			Debug.Log("Ink Portal Has Been Touched");
			travelUI.TravelUI("PortalToInk");
		}
	}

}

