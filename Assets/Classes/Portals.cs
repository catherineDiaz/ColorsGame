using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour {

    private GameObject PortalToPaint;
	private GameObject PortalToWaterColor;
	private GameObject PortalToInk;
	GameObject playerObj;
    int once;
    int once2;




	void Start()
	{
		PortalToPaint = Instantiate(Resources.Load("PortalToPaint") as GameObject);
		PortalToWaterColor = Instantiate(Resources.Load("PortalToWaterColor") as GameObject);
		//PortalToInk = Instantiate(Resources.Load("PortalToInk") as GameObject);
		playerObj = GameObject.Find("Player");
        once = 0;
        once2 = 0;


	}

    // Update is called once per frame
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
		
	}
}
