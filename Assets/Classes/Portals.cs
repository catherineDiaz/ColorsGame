using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portals : MonoBehaviour {

    private GameObject PortalToPaint;
	private GameObject PortalToWaterColor;
	private GameObject PortalToInk;
	GameObject playerObj;
    int once;
    int once2;
    int once3;



	/**
	    Initializes the portals object

    */
	void Start()
	{
		PortalToPaint = Instantiate(Resources.Load("PortalToPaint") as GameObject);
		PortalToWaterColor = Instantiate(Resources.Load("PortalToWaterColor") as GameObject);
		PortalToInk = Instantiate(Resources.Load("PortalToInk") as GameObject);
		playerObj = GameObject.Find("Player");
        once = 0;
        once2 = 0;
        once3 = 0;


	}

	/**
	    Checks if universes are complete and if they are then destroy the portal to them 

    */
	void Update () {
        
        if(playerObj.GetComponent<Player>().completedPaint == true && once == 0)
        {
            Destroy(PortalToPaint);
            once = 1;
            
        }

        if (playerObj.GetComponent<Player>().completedWaterColor == true && once2 == 0)
		{
            Destroy(PortalToWaterColor);
			once2 = 1;

		}

		if (playerObj.GetComponent<Player>().completedInk == true && once3 == 0)
		{
			Destroy(PortalToInk);
			once3 = 1;

		}

        if(playerObj.GetComponent<Player>().completedInk == true && playerObj.GetComponent<Player>().completedPaint == true && playerObj.GetComponent<Player>().completedWaterColor == true)
        {

			Debug.Log("GoodBye!");
			SceneManager.LoadScene("EndingScene", LoadSceneMode.Single);
			
            
        }
		
	}
}
