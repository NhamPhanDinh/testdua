using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
		//score for combo mode
		private const int COMBO_2_SCORE = 2;
		private const int COMBO_3_SCORE = 3;
		private const int COMBO_4_SCORE = 4;
		private const int COMBO_5_SCORE = 5;
		private const int COMBO_10_SCORE = 10;
		private const int COMBO_20_SCORE = 20;
		private const int COMBO_30_SCORE = 30;
		private const int COMBO_40_SCORE = 40;
		//cookie  to get combo mode
		private const int COMBO_2 = 2;
		private const int COMBO_3 = 3;
		private const int COMBO_4 = 4;
		private const int COMBO_5 = 5;
		private const int COMBO_10 = 10;
		private const int COMBO_20 = 20;
		private const int COMBO_30 = 30;
		private const int COMBO_40 = 40;
		//cookies
		public static int cookiesTotal;
		//cookies per second
		public float cookiesPerSecond;
		public static float currentCookies;
		//time
		public static float currentTime;
		public static float currentVelocity;
		public static bool beginGetCookies;
		//UI
		public tk2dTextMesh velocityText;
		public tk2dTextMesh cookiesTotalText;
		//miniCookies
		public static int currentColorMiniCookies;
		// Use this for initialization
		void Start ()
		{

				currentTime = 0.0f;
				currentCookies = 0.0f;
				beginGetCookies = false;
				currentColorMiniCookies = 1;
				cookiesTotal = PlayerPrefs.GetInt ("CookiesTotal");
				//cookiesTotal = 100000;
				currentColorMiniCookies = PlayerPrefs.GetInt ("CookiesColor");
				if (currentColorMiniCookies == 0)
						currentColorMiniCookies = 1;
	    
		}
	
		// Update is called once per frame
		void Update ()
		{
				currentTime += Time.deltaTime;
				cookiesTotalText.text = cookiesTotal.ToString () + " Cookies!";
				cookiesTotalText.Commit ();
				if (currentTime > 1.0f) {
						velocityText.text = currentCookies.ToString () + " per second";
						velocityText.Commit ();
						currentTime = 0.0f;
						beginGetCookies = false;
				}
	
		}
}
