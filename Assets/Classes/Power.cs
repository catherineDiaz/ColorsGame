using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Power : MonoBehaviour {

	string powerName_;
	public GameObject ball;
	GameObject person;
	Vector3 position_;
	int once;
	GameObject camera1;
	GameObject camera2;

	public bool isUsingPowerBall;
    private GameObject ballText;
    GameObject[] mazeWallArray = new GameObject[28];
    Material mazeWallTransparentMat;

	/**
    	Initializes Power object, the constructor

	*/
	void Start()
	{
		powerName_ = this.name;
		bool now = false;
		once = 0;
		person = GameObject.Find("ThirdPersonController");
		person.SetActive(true);
		isUsingPowerBall = false;

        if (SceneManager.GetActiveScene().name == "WaterColorUniverse")
        {
            for (int i = 0; i <= 27; i++)
            {
                int j = i + 1;
                GameObject currCube = GameObject.Find("pCube" + j.ToString());
                mazeWallArray[i] = currCube;
                Debug.Log(currCube.name);

            }
        }

        mazeWallTransparentMat = Resources.Load("mazeWallTransparentMat", typeof(Material)) as Material;




	}

	/**
    	If a power is touched, apply the power to the player

	*/
	public void ApplyPower()
	{
		if(gameObject.name == "ballPower") // If the object touched was the ball power
		{
			if(SceneManager.GetActiveScene().name == "PaintUniverse")
			{
				GameObject.Find("Player").GetComponent<Player>().isUsingRollerPower = true;	
                ballText = Instantiate(Resources.Load("ballText") as GameObject);
				
			}


		}
	}

    public void xRayWallApply(string wallPower)
	{
		if (wallPower == "xRayWallPower1")
		{
            int j = 0;
			for (int i = 0; i <= 8; i++)
			{
				GameObject wall = mazeWallArray[j];
				Renderer wallRenderer = wall.GetComponent<Renderer>();
				wallRenderer.material = mazeWallTransparentMat;
                j = j + 3;

			}
            Destroy(GameObject.Find(wallPower));
		}
		if (wallPower == "xRayWallPower2")
		{
			int j = 1;
			for (int i = 0; i <= 8; i++)
			{
				GameObject wall = mazeWallArray[j];
				Renderer wallRenderer = wall.GetComponent<Renderer>();
				wallRenderer.material = mazeWallTransparentMat;
				j = j + 3;

			}
            Destroy(GameObject.Find(wallPower));
		}
		if (wallPower == "xRayWallPower3")
		{
			int j = 2;
			for (int i = 0; i <= 8; i++)
			{
				GameObject wall = mazeWallArray[j];
				Renderer wallRenderer = wall.GetComponent<Renderer>();
				wallRenderer.material = mazeWallTransparentMat;
				j = j + 3;

			}
            Destroy(GameObject.Find(wallPower));
		}
		if (wallPower == "xRayWallPower4")
		{
			int j = 3;
			for (int i = 0; i <= 8; i++)
			{
				GameObject wall = mazeWallArray[j];
				Renderer wallRenderer = wall.GetComponent<Renderer>();
				wallRenderer.material = mazeWallTransparentMat;
				j = j + 3;

			}
            Destroy(GameObject.Find(wallPower));
		}
	}

	/**
    	Waiting for collision on the power 3D object in the game, if another game object (the Player)
    	collides with the Power then the UI is initialized and asks the player if they want to use
    	the power now or later

	*/
	void OnCollisionEnter (Collision col)
	{
		if (gameObject.name == "ballPower" && once == 0) 
		{
			once = 1;
			Debug.Log("Ball Power Object Touched");
            ApplyPower();

		}

        if (gameObject.name == "xRayWallPower1" || gameObject.name == "xRayWallPower2" || gameObject.name == "xRayWallPower3"|| gameObject.name == "xRayWallPower4")
        {
            xRayWallApply(gameObject.name);
        }



	}



	void Update () {


        if (SceneManager.GetActiveScene().name == "WaterColorUniverse")
        {
            gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 20);
        }


		
	}
}
