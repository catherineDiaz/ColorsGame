using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour {

	// Use this for initialization
	Button quit;


	//For if a user collects a power
	GameObject powerUI;
	Button useNow;
	Button useLater;

	//For if a user goes to a portal
	GameObject travelUIPaint;
    GameObject travelUIWaterColor;
    GameObject travelUIInk;


	//For if a user gets paint token
	GameObject tokenUIPaint;
	Button GoingBackHomeFromPaint;

	Universe loadObj;

	GameObject playerObj;
	GameObject player;
	GameObject rollerBall;

	Player playerScript;

	Power ball;

    GameObject Cam;

	/**
    	Initializes the UI object

	*/
	void Start () {

		player = GameObject.Find("ThirdPersonController");
		rollerBall = GameObject.Find("RollerBall");
		playerObj = GameObject.Find("Player");
        Cam = GameObject.Find("FreeLookCameraRig");

	}


	/**
    	Loads the UI for if a user runs into a portal, wanting to travel

	*/
	public void TravelUI(string nameOfObjectTouched)
	{
        if (nameOfObjectTouched == "PortalToPaint")
        {
            travelUIPaint = Instantiate(Resources.Load("TravelToPaint") as GameObject);

        }
		if (nameOfObjectTouched == "PortalToWaterColor")
		{
			travelUIWaterColor = Instantiate(Resources.Load("TravelToWaterColor") as GameObject);

		}
		if (nameOfObjectTouched == "PortalToInk")
		{
			travelUIInk = Instantiate(Resources.Load("TravelToInk") as GameObject);

		}

	}

	/**
    	Loads the UI for if a user collects the token at the end of a level

	*/
	public void TokenUIPaint()
	{
		tokenUIPaint = Instantiate(Resources.Load("tokenUIPaint") as GameObject);
		//GoingBackHomeFromPaint = GameObject.Find("GoingBackHomeFromPaint").GetComponent<UnityEngine.UI.Button>();
	}

	/**
    	If the user clicks the use now button, then apply the ball power to the player

	*/
	public void useNowClick()
	{
		Debug.Log("Transforming into a ball...");
		ball = GameObject.Find("ballPower").GetComponent<Power>();
		ball.ApplyPower();
		Destroy(GameObject.Find("ballPower"));
	}


	/**
    	If the user clicks the use later button, then store the power for later

	*/
	public void userLaterClick()
	{
		Debug.Log("Storing the power for later...");
		Destroy(powerUI);
		Destroy(GameObject.Find("ballPower"));
		
	}


	/**
    	Exit the application button

	*/
	public void ExitClick()
	{
		Debug.Log("GoodBye!");
		Application.Quit();	
	}


	/**
    	If the user clicks the travel to new universe button then change the scene and move the 
		player to the new scene with different position

        For Paint Universe

	*/
	public void YesTravelNowPaintClick()
	{
		Debug.Log("Traveling to Paint Universe");
		SceneManager.LoadScene("PaintUniverse", LoadSceneMode.Single);
		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("PaintUniverse"));
		DontDestroyOnLoad(playerObj);
		playerObj.transform.position = new Vector3(0f, 2f, 0f);
		player.transform.position = new Vector3(0f, 2f, 0f);
        Cam.transform.position = new Vector3(-200f, 0f, 0f);
		Destroy(travelUIPaint);
	}

	/**
	    If the user clicks the travel to new universe button then change the scene and move the 
	    player to the new scene with different position

        For Water Color Universe

    */
	public void YesTravelNowWaterColorClick()
	{
		Debug.Log("Traveling to Water Color Universe");
		SceneManager.LoadScene("WaterColorUniverse", LoadSceneMode.Single);
		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("WaterColorUniverse"));
		DontDestroyOnLoad(playerObj);
		playerObj.transform.position = new Vector3(0f, 0f, 0f);
		player.transform.position = new Vector3(0f, 0f, 0f);
        Cam.transform.position = new Vector3(200f, 100f, 0f);
		Destroy(travelUIWaterColor);
	}
	/**
        If the user clicks the travel to new universe button then change the scene and move the 
        player to the new scene with different position

        For Ink Universe

    */
	public void YesTravelNowInkClick()
	{
		Debug.Log("Traveling to Ink Universe");
		SceneManager.LoadScene("InkUniverse", LoadSceneMode.Single);
		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("InkUniverse"));
		DontDestroyOnLoad(playerObj);
		playerObj.transform.position = new Vector3(0f, 0f, 0f);
		player.transform.position = new Vector3(0f, 0f, 0f);
        Cam.transform.position = new Vector3(0f, 0f, -200f);
		Destroy(travelUIInk);
	}


	/**
    	For if the user does not want to travel to a new universe at the moment
    	
    	For Paint Universe

	*/
	public void NoNotNowPaintClick()
	{
		Destroy(travelUIPaint);
	}
	/**
	    For if the user does not want to travel to a new universe at the moment

        For Water Color Universe

    */
	public void NoNotNowWaterColorClick()
	{
		Destroy(travelUIWaterColor);
	}
	/**
	    For if the user does not want to travel to a new universe at the moment

        For Ink Universe

    */
	public void NoNotNowInkClick()
	{
		Destroy(travelUIInk);
	}

	/**
    	For when the user collects a token and needs to go back to the home land

	*/
	public void GoingBackHomeFromPaintClick()
	{
		
		Debug.Log("Going Back Home From Paint");
		SceneManager.LoadScene("HomeLand", LoadSceneMode.Single);
		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("HomeLand"));
        DontDestroyOnLoad(playerObj);
		playerObj.GetComponent<Player>().ChangeBackToPlayer();
		player = GameObject.Find("ThirdPersonController");
		playerObj.transform.position = new Vector3(0,25,0);
        player.transform.position = new Vector3(0, 25, 0);


	}
	/**
	 
	    For when the user collects a token and needs to go back to the home land

    */
	public void GoingBackHomeFromWaterColorClick()
	{

		Debug.Log("Going Back Home From Water Color");
		SceneManager.LoadScene("HomeLand", LoadSceneMode.Single);
		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("HomeLand"));
		DontDestroyOnLoad(playerObj);
		playerObj.GetComponent<Player>().ChangeBackToPlayer();
		playerObj.transform.position = new Vector3(0, 25, 0);
		player.transform.position = new Vector3(0, 25, 0);


	}

	/**
 
	For when the user collects a token and needs to go back to the home land

    */
	public void GoingBackHomeFromInkClick()
	{

		Debug.Log("Going Back Home From Ink");
		SceneManager.LoadScene("HomeLand", LoadSceneMode.Single);
		SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("HomeLand"));
		DontDestroyOnLoad(playerObj);
		playerObj.GetComponent<Player>().ChangeBackToPlayer();
		playerObj.transform.position = new Vector3(0, 25, 0);
		player.transform.position = new Vector3(0, 25, 0);


	}



	void Update () {


		
	}
}

