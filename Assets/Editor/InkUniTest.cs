using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class InkUniTest {

	[Test]
	public void InkUniTestSimplePasses() {
        // Use the Assert class to test conditions.
        GameObject playerFollow = GameObject.Find("PlayerFollow");
        Assert.NotNull(playerFollow);

		GameObject inkToken = GameObject.Find("inkToken");
        Assert.NotNull(inkToken);

        GameObject inkPlane = GameObject.Find("inkPlane");
        Assert.NotNull(inkPlane);

		GameObject inkPieces = GameObject.Find("inkPieces");
        Assert.NotNull(inkPieces);

		GameObject allRectangle = GameObject.Find("allRectangle");
		Assert.NotNull(allRectangle);

		GameObject inkPieceUI = GameObject.Find("inkPieceUI");
		Assert.NotNull(inkPieceUI); 

        GameObject tokenUIInk = GameObject.Find("tokenUIInk");
		Assert.NotNull(tokenUIInk);


	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator InkUniTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
