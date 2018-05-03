using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PaintUniTest {

	[Test]
	public void PaintUniTestSimplePasses() {
        // Use the Assert class to test conditions.

		GameObject tokenUIPaint = GameObject.Find("tokenUIPaint");
        Assert.NotNull(tokenUIPaint);

        GameObject bridge = GameObject.Find("waterColorBridge");
        Assert.NotNull(bridge);

		GameObject pipeWater = GameObject.Find("pipeWaterColor");
        Assert.NotNull(pipeWater);

		GameObject funnelWaterColor = GameObject.Find("funnelWaterColor");
		Assert.NotNull(funnelWaterColor);

		GameObject wavePlane = GameObject.Find("wavePlane");
		Assert.NotNull(wavePlane);

		GameObject bounce = GameObject.Find("Bounce");
        Assert.NotNull(bounce); 

        GameObject bridgePaint = GameObject.Find("brid");
		Assert.NotNull(bridgePaint);

		GameObject paintToken = GameObject.Find("paintToken");
		Assert.NotNull(paintToken);

		GameObject ballPower = GameObject.Find("ballPower");
		Assert.NotNull(ballPower);


	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator PaintUniTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
