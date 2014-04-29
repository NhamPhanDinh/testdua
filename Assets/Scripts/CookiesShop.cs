using UnityEngine;
using System.Collections;

public class CookiesShop : MonoBehaviour
{
		public tk2dSprite mainCookiesSprite;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void buyCookies1 ()
		{
				int checkShop = PlayerPrefs.GetInt ("shop1");
				if (GameManager.cookiesTotal >= 100 && checkShop == 0) {
						Debug.Log ("Buy");
						GameManager.currentColorMiniCookies = 1;
						mainCookiesSprite.SetSprite ("mainCookies_" + GameManager.currentColorMiniCookies.ToString ());
						mainCookiesSprite.ForceBuild ();
						MainCookie.currentAnimation = "Down_" + GameManager.currentColorMiniCookies.ToString ();
						GameManager.cookiesTotal -= 100;
						PlayerPrefs.SetInt ("shop1", 1);
				}
		}

		void buyCookies2 ()
		{
				int checkShop = PlayerPrefs.GetInt ("shop2");
				if (GameManager.cookiesTotal >= 200 && checkShop == 0) {
						Debug.Log ("Buy");
						GameManager.currentColorMiniCookies = 2;
						mainCookiesSprite.SetSprite ("mainCookies_" + GameManager.currentColorMiniCookies.ToString ());
						mainCookiesSprite.ForceBuild ();
						MainCookie.currentAnimation = "Down_" + GameManager.currentColorMiniCookies.ToString ();
						GameManager.cookiesTotal -= 200;
						PlayerPrefs.SetInt ("shop2", 1);
				}
		}

		void buyCookies3 ()
		{
		int checkShop = PlayerPrefs.GetInt ("shop3");
				if (GameManager.cookiesTotal >= 300 && checkShop == 0) {
						GameManager.currentColorMiniCookies = 3;
						mainCookiesSprite.SetSprite ("mainCookies_" + GameManager.currentColorMiniCookies.ToString ());
						mainCookiesSprite.ForceBuild ();
						MainCookie.currentAnimation = "Down_" + GameManager.currentColorMiniCookies.ToString ();
						GameManager.cookiesTotal -= 300;
						PlayerPrefs.SetInt ("shop3", 1);
				}
		}

		void buyCookies4 ()
		{
		int checkShop = PlayerPrefs.GetInt ("shop4");
				if (GameManager.cookiesTotal >= 400 && checkShop == 0) {
						GameManager.currentColorMiniCookies = 4;
						mainCookiesSprite.SetSprite ("mainCookies_" + GameManager.currentColorMiniCookies.ToString ());
						mainCookiesSprite.ForceBuild ();
						MainCookie.currentAnimation = "Down_" + GameManager.currentColorMiniCookies.ToString ();
						GameManager.cookiesTotal -= 400;
						PlayerPrefs.SetInt ("shop4", 1);
				}
		}

		void buyCookies5 ()
		{
		int checkShop = PlayerPrefs.GetInt ("shop5");
				if (GameManager.cookiesTotal >= 500 && checkShop == 0) {
						GameManager.currentColorMiniCookies = 5;
						mainCookiesSprite.SetSprite ("mainCookies_" + GameManager.currentColorMiniCookies.ToString ());
						mainCookiesSprite.ForceBuild ();
						MainCookie.currentAnimation = "Down_" + GameManager.currentColorMiniCookies.ToString ();
						GameManager.cookiesTotal -= 500;
						PlayerPrefs.SetInt ("shop5", 1);
				}
		}

		void buyCookies6 ()
		{
				if (GameManager.cookiesTotal >= 600) {
						GameManager.currentColorMiniCookies = 6;
						GameManager.cookiesTotal -= 600;
				}
		}

		void buyCookies7 ()
		{
				if (GameManager.cookiesTotal >= 700) {
						GameManager.currentColorMiniCookies = 7;
						GameManager.cookiesTotal -= 700;
				}
		}

		void buyCookies8 ()
		{
				if (GameManager.cookiesTotal >= 800) {
						GameManager.currentColorMiniCookies = 8;
						GameManager.cookiesTotal -= 800;
				}
		}
}
