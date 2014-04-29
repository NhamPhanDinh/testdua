using UnityEngine;
using System.Collections;
using Prime31;

public class AdMobUIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if UNITY_ANDROID
		AdMobAndroid.init("a15312a8eb50af0");
		AdMobAndroid.createBanner(AdMobAndroidAd.phone320x50, AdMobAdPlacement.BottomCenter );
		#elif UNITY_IPHONE
		AdMobBinding.init("a15312abc21db24");
		AdMobBinding.createBanner(AdMobBannerType.iPad_468x60, AdMobAdPosition.BottomCenter );
		#endif
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
