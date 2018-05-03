using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class WaterColorUniTest {

	[Test]
	public void WaterColorUniTestSimplePasses() {
        // Use the Assert class to test conditions.


		GameObject tokenUIWaterColor = GameObject.Find("tokenUIWaterColor");
        Assert.NotNull(tokenUIWaterColor);

        GameObject mazeLevel = GameObject.Find("MazeLevel1");
        Assert.NotNull(mazeLevel);

		GameObject waterColToken = GameObject.Find("waterColorToken");
        Assert.NotNull(waterColToken);

		GameObject xRayPow1 = GameObject.Find("xRayWallPower1");
		Assert.NotNull(xRayPow1);

		GameObject xRayPow2 = GameObject.Find("xRayWallPower2");
		Assert.NotNull(xRayPow2);

		GameObject xRayPow3 = GameObject.Find("xRayWallPower3");
		Assert.NotNull(xRayPow3);




	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator WaterColorUniTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
