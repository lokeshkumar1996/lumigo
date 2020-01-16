using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class normalsahre : MonoBehaviour
{

	public  Button shareButton;

	private bool isFocus = false;
	private bool isProcessing = false;
	int level;

	void  Start () {
		shareButton.onClick.AddListener (ShareText);

		level = AudioManager.instance.leveldone;
		
	}

	void OnApplicationFocus (bool focus) {
		isFocus = focus;
	}

	private void ShareText () {

		#if UNITY_ANDROID
		if (!isProcessing) {
			StartCoroutine (ShareTextInAnroid ());
		}
		#else
		Debug.Log("No sharing set up for this platform.");
		#endif
	}



	#if UNITY_ANDROID
	public IEnumerator ShareTextInAnroid () {

       // var referal = PlayerPrefs.GetString("ReferalCode");
		var shareSubject = "Check out this Awesome game";

		
		var shareMessage = "I Love playing this game, Mesmerizing Neon Space and Fluid style combo, its totally Awesome.\n" +
		                   "Get '"+ Application.productName +"' from the link below. \n\n" +
		                   "https://play.google.com/store/apps/details?id="+Application.identifier;
		
		if(level >= 3){
					shareMessage = "I Love playing this game, Mesmerizing Neon Space and Fluid style combo, its totally Awesome.\n" +
							"I am at Level"+level+" try to catch up with me \n" +
		                   "Get '"+ Application.productName +"' from the link below. \n\n" +
		                   "https://play.google.com/store/apps/details?id="+Application.identifier;
					 }
		

       // Debug.Log(shareMessage);
        
		isProcessing = true;

		if (!Application.isEditor) {
			//Create intent for action send
			AndroidJavaClass intentClass = 
				new AndroidJavaClass ("android.content.Intent");
			AndroidJavaObject intentObject = 
				new AndroidJavaObject ("android.content.Intent");
			intentObject.Call<AndroidJavaObject> 
				("setAction", intentClass.GetStatic<string> ("ACTION_SEND"));

			//put text and subject extra
			intentObject.Call<AndroidJavaObject> ("setType", "text/plain");
			intentObject.Call<AndroidJavaObject> 
				("putExtra", intentClass.GetStatic<string> ("EXTRA_SUBJECT"), shareSubject);
			intentObject.Call<AndroidJavaObject> 
				("putExtra", intentClass.GetStatic<string> ("EXTRA_TEXT"), shareMessage);

			//call createChooser method of activity class
			AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
			AndroidJavaObject currentActivity = 
				unity.GetStatic<AndroidJavaObject> ("currentActivity");
			AndroidJavaObject chooser = 
				intentClass.CallStatic<AndroidJavaObject> 
				("createChooser", intentObject, "Invite your friend");
			currentActivity.Call ("startActivity", chooser);
		}

		yield return new WaitUntil (() => isFocus);
		isProcessing = false;
	}
	#endif




	public void RAteuslick()
    {
        
        /// code for rating;
        
        //Application.OpenURL ("market://details?id=com.trollugames.caverun3d");
        //print("RateMe..........!!!!!" + Application.identifier);
        Application.OpenURL("market://details?id=" + Application.identifier);
        //Application.OpenURL("http://play.google.com/store/apps/details?id=" + Application.bundleIdentifier);
        PlayerPrefs.SetInt("rating",1);
        //PlayerPrefs.SetInt("diamonds",(PlayerPrefs.GetInt("diamonds") + 500 ));


        
    }
}

