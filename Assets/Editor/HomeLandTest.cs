using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class HomeLandTest {

	[Test]
	public void HomeLandTestSimplePasses() {
        // Use the Assert class to test conditions.
        GameObject player = GameObject.Find("Player");
        Assert.NotNull(player);

		GameObject uiController = GameObject.Find("UIController");
        Assert.NotNull(uiController);

        GameObject homeLandObj = GameObject.Find("HomeLand");
        Assert.NotNull(homeLandObj);

		GameObject portals = GameObject.Find("Portals");
        Assert.NotNull(portals);

	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator HomeLandTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
