using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InkPiece : MonoBehaviour {
    
    GameObject inkPiece1;
    GameObject inkPiece2;
    GameObject inkPiece3;
    GameObject inkPiece4;

    public GameObject inkPiecePic1;
    public GameObject inkPiecePic2;
    public GameObject inkPiecePic3;
    public GameObject inkPiecePic4;

    InkUniverse inkPieceCall;
    public GameObject inkOf4;

    public bool obj1 = false;
    public bool obj2 = false;
    public bool obj3 = false;
    public bool obj4 = false;




	/**
        Initializes the Ink Piece object

    */
	void Start () {
        
        inkPiece1 = GameObject.Find("inkPiece1");
        inkPiece2 = GameObject.Find("inkPiece2");
        inkPiece3 = GameObject.Find("inkPiece3");
        inkPiece4 = GameObject.Find("inkPiece4");

        inkPieceCall = GameObject.Find("inkToken").GetComponent<InkUniverse>();
		   	
	}


	/**
	    If an ink piece is collected, update the interface and increment the counter depending on which piece is collected 

        @params col - the collision that is detected

    */
	void OnCollisionEnter(Collision col)
	{
        int inkPieceCount = inkPieceCall.incrementInkPiece();
		inkPieceCount = inkPieceCount + 1;
		Debug.Log(inkPieceCount);



		if (gameObject.name == "inkPiece1")
		{
			Debug.Log("Ink Piece 1 found");
            Image pic1 = inkPiecePic1.GetComponent<Image>();
            Color newColor1 = pic1.color;
			newColor1.a = 1;
            pic1.color = newColor1;
            inkPieceUIDisplay(inkPieceCount);
            Destroy(inkPiece1);

		}
		if (gameObject.name == "inkPiece2" )
		{
			Debug.Log("Ink Piece 2 found");
			Image pic2 = inkPiecePic2.GetComponent<Image>();
			Color newColor2 = pic2.color;
			newColor2.a = 1;
			pic2.color = newColor2;
            inkPieceUIDisplay(inkPieceCount);
            Destroy(inkPiece2);

		}
		if (gameObject.name == "inkPiece3" )
		{
			Debug.Log("Ink Piece 3 found");
			Image pic3 = inkPiecePic3.GetComponent<Image>();
			Color newColor3 = pic3.color;
			newColor3.a = 1;
            pic3.color = newColor3;
            inkPieceUIDisplay(inkPieceCount);
            Destroy(inkPiece3);

		}
		if (gameObject.name == "inkPiece4" )
		{
			Debug.Log("Ink Piece 4 found");
			Image pic4 = inkPiecePic4.GetComponent<Image>();
			Color newColor4 = pic4.color;
			newColor4.a = 1;
            pic4.color = newColor4;
            inkPieceUIDisplay(inkPieceCount);
            Destroy(inkPiece4);


		}

	}


	/**
	    Update the interface if an ink piece is collected

	    @params numColleced - the total number of ink pieces collected

    */
	void inkPieceUIDisplay (int numCollected)
    {
        Text inkText = inkOf4.GetComponent<Text>();

        if (numCollected == 1)
        {
            inkText.text = "1 out of 4 Ink Pieces Found";
            Debug.Log(inkText.text);

        }
		else if (numCollected == 2)
		{
            inkText.text = "2 out of 4 Ink Pieces Found";
            Debug.Log(inkText.text);

		}
		else if (numCollected == 3)
		{
            inkText.text = "3 out of 4 Ink Pieces Found";
            Debug.Log(inkText.text);

		}
        else //(numCollected == 4)
		{
            inkText.text = "4 out of 4 Ink Pieces Found";
            Debug.Log(inkText.text);

		}

    }

	/**
        Constantly rotate the ink piece game object to indicate interactivity

    */
	void Update () {

        if(gameObject.name == "inkPiece1" || gameObject.name == "inkPiece2" || gameObject.name == "inkPiece3" || gameObject.name == "inkPiece4" )
        {
			gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 20);
			gameObject.transform.Rotate(Vector3.right * Time.deltaTime * 20);   
        }



		
	}
}
