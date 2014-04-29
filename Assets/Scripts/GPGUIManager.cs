using UnityEngine;
using System.Collections;

public class GPGUIManager : Prime31.MonoBehaviourGUI
{

		// Use this for initialization
		void Start ()
		{
				#if UNITY_ANDROID
		PlayGameServices.enableDebugLog( true );
		
		// we always want to call init as soon as possible after launch. Be sure to pass your own clientId to init on iOS!
		// This call is not required on Android.
		//PlayGameServices.init( "YOUR_CLIENT_ID", true );
		PlayGameServices.init( "366869334068.apps.googleusercontent.com", true );

		PlayGameServices.authenticate();

				#endif
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void ShowLeaderboard ()
		{
				PlayGameServices.submitScore ("CgkItJD32NYKEAIQAQ", GameManager.cookiesTotal);
				PlayGameServices.showLeaderboard ("CgkItJD32NYKEAIQAQ", GPGLeaderboardTimeScope.AllTime);

		}
}
