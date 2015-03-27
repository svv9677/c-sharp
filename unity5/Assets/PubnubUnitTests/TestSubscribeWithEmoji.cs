using System;
using System.Collections;
using UnityEngine;
using PubNubMessaging.Core;

namespace PubNubMessaging.Tests
{
	[IntegrationTest.DynamicTestAttribute ("TestSubscribeWithEmoji")]
	public class TestSubscribeWithEmoji: MonoBehaviour
	{
		public IEnumerator Start ()
		{
			CommonIntergrationTests common = new CommonIntergrationTests ();
			string TestName = "TestSubscribeWithEmoji";

			string message = "Text with 😜 emoji 🎉.";

			yield return StartCoroutine(common.DoSubscribeThenPublishAndParse(false, TestName, false, false, message));
			UnityEngine.Debug.Log (string.Format("{0}: After StartCoroutine", TestName));
			yield return new WaitForSeconds (CommonIntergrationTests.WaitTimeBetweenCalls);

		}
	}
}
