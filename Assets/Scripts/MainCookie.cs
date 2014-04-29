using UnityEngine;
using System.Collections;

public class MainCookie : MonoBehaviour
{

		private RaycastHit hit;
		private Ray ray;
		public tk2dSpriteAnimator mainCookies;
		public tk2dSprite mainCookiesSprite;
		public GameObject miniCookies;
		public GameObject comboCookies;
		public GameObject scoreText;
		public tk2dTextMesh test;
		public const float MAX_SCALE = 1.0f;
		public const float MIN_SCALE = 0.35f;
		public const float SPEED_DECREASE = 0.25f;
		public const float SPEED_INCREASE = 1.0f;
		public string currentSprite;
		public static string currentAnimation;
		private int timerToGetCombo = 0;
		private bool getCombo = false;
		public GameObject effectObj;
		// Use this for initialization
		void Start ()
		{
				
				int currentColorMiniCookies = PlayerPrefs.GetInt ("CookiesColor");
				if (currentColorMiniCookies == 0)
						currentColorMiniCookies = 1;
				currentSprite = "mainCookies_" + currentColorMiniCookies.ToString ();
				currentAnimation = "Down_" + currentColorMiniCookies.ToString ();
				mainCookiesSprite.SetSprite (currentSprite);
				mainCookiesSprite.ForceBuild ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				//singe touch for PC version
				/*
				if (Input.GetMouseButtonDown (0)) {
						ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						//Vector3 pos = Camera.main.WorldToScreenPoint (Input.mousePosition);
						if (Physics.Raycast (ray, out hit, 100.0f) && hit.collider.gameObject.name == "MainCookie") {
								Debug.Log (hit.collider.gameObject.name);
								if (GameManager.beginGetCookies)
										GameManager.currentCookies++;
								mainCookies.Play (currentAnimation);	
								Instantiate (effectObj, effectObj.transform.localPosition, Quaternion.identity);
								SpawnMiniCookies ();
								Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
								pos.z = -2.0f;
								genCombo (pos);
								if (transform.localScale.x >= 1)
										timerToGetCombo++;
								if (transform.localScale.x < 1)
										timerToGetCombo = 0;
								if (timerToGetCombo > 15) {
										GameManager.cookiesTotal += 15;
										SpawnScore (15, pos);
								}
						}
				} 

*/
				

				// multi touches for mobile version
			
				var fingerCount = 0;
				foreach (Touch touch in Input.touches) {
						if (touch.phase == TouchPhase.Began) {
								ray = Camera.main.ScreenPointToRay (touch.position);
								//Vector3 pos = Camera.main.WorldToScreenPoint (Input.mousePosition);
								if (Physics.Raycast (ray, out hit, 100.0f) && hit.collider.gameObject.name == "MainCookie") {
										Debug.Log (hit.collider.gameObject.name);
										if (GameManager.beginGetCookies)
												GameManager.currentCookies++;
										mainCookies.Play (currentAnimation);	
										Instantiate (effectObj, effectObj.transform.localPosition, Quaternion.identity);
										if (transform.localScale.x < MAX_SCALE) {
												float scaleToMin = SPEED_INCREASE * Time.deltaTime;
												transform.localScale = new Vector3 (transform.localScale.x + scaleToMin, transform.localScale.y + scaleToMin, 
					                                    transform.localScale.z);
										}
										SpawnMiniCookies ();
										Vector3 pos = Camera.main.ScreenToWorldPoint (touch.position);
										pos.z = -2.0f;
										if (transform.localScale.x >= 1)
												timerToGetCombo++;
										if (transform.localScale.x < 1)
												timerToGetCombo = 0;
										if (timerToGetCombo > 40) {
												GameManager.cookiesTotal += 15;
												SpawnScore (15, pos);
										} else
												genCombo (pos);
								}
						}
								
				}
			

				if (!GameManager.beginGetCookies) {
						GameManager.currentTime = 0.0f;
						GameManager.beginGetCookies = true;
						GameManager.currentCookies = 0.0f;
				}
				//check to scale min
				if (GameManager.currentCookies < 2 && transform.localScale.x >= MIN_SCALE) {
						float scaleToMin = SPEED_DECREASE * Time.deltaTime;
						transform.localScale = new Vector3 (transform.localScale.x - scaleToMin, transform.localScale.y - scaleToMin, 
			                                    transform.localScale.z);
				}
		}

		void SpawnMiniCookies ()
		{
				Instantiate (miniCookies, new Vector3 (0, 0, 0), Quaternion.identity);
		}

		void SpawnCombo (int comboMode, Vector3 pos)
		{
				GameObject comboPrefab = (GameObject)Instantiate (comboCookies, pos, Quaternion.identity);
				Combo comboScript = (Combo)comboPrefab.GetComponent ("Combo");
				comboScript.setSprite (comboMode);
		}

		void SpawnScore (int score, Vector3 pos)
		{
				GameObject scorePrefab = (GameObject)Instantiate (scoreText, pos, Quaternion.identity);
				Score scoreScript = (Score)scorePrefab.GetComponent ("Score");
				scoreScript.setScore (score);
		}

		float CaculateVelocity (int currentTime)
		{
				float velocity = 0.0f;
				if (currentTime > GameManager.currentTime)
						velocity = 1000.0f / (float)(currentTime - GameManager.currentTime);
				else
						velocity = 12.0f;
				return velocity;
		}

		void setCookiesPlus (Vector3 pos)
		{
				if (GameManager.currentCookies >= 1 && GameManager.currentCookies <= 12) {
						GameManager.cookiesTotal++;
						SpawnScore (1, pos);
				} else if (GameManager.currentCookies >= 13 && GameManager.currentCookies <= 24) {
						GameManager.cookiesTotal = GameManager.cookiesTotal + 2;
						SpawnScore (2, pos);
				} else if (GameManager.currentCookies >= 25 && GameManager.currentCookies <= 30) {
						GameManager.cookiesTotal = GameManager.cookiesTotal + 3;
						SpawnScore (3, pos);
				} else if (GameManager.currentCookies >= 31) {
						GameManager.cookiesTotal = GameManager.cookiesTotal + 4;
						SpawnScore (4, pos);
				}
		}

		void genCombo (Vector3 pos)
		{
				if (GameManager.currentColorMiniCookies == 1) {
						GameManager.cookiesTotal++;
						SpawnScore (1, pos);
				} else if (GameManager.currentColorMiniCookies == 2) {
						GameManager.cookiesTotal += 2;
						SpawnScore (2, pos);
				} else if (GameManager.currentColorMiniCookies == 3) {
						GameManager.cookiesTotal += 5;
						SpawnScore (5, pos);
				} else if (GameManager.currentColorMiniCookies == 4) {
						GameManager.cookiesTotal += 7;
						SpawnScore (7, pos);
				} else if (GameManager.currentColorMiniCookies == 5) {
						GameManager.cookiesTotal += 10;
						SpawnScore (10, pos);
				} 
		}

}
