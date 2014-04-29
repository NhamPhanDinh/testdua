using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour
{
		public GameObject shopList;
		public GameObject shopListContent;
		private bool shopIsShow;
		// Use this for initialization
		void Start ()
		{
				shopIsShow = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				if (Input.GetKeyDown (KeyCode.Escape)) {
						SubmitScore ();
						PlayerPrefs.SetInt ("CookiesTotal", GameManager.cookiesTotal);
						PlayerPrefs.SetInt ("CookiesColor", GameManager.currentColorMiniCookies);
						Application.Quit ();
				}
		}

		void showShopList ()
		{
				if (!shopIsShow) {
						//shopListContent.transform.position = new Vector3 (shopListContent.transform.position.x, 0, shopListContent.transform.position.z);
						StartCoroutine (MoveObject (shopList.transform, shopList.transform.position,
		                new Vector3 (shopList.transform.position.x,
		                shopList.transform.position.y + 3700.0f, shopList.transform.position.z), 0.25f));
				}
		}

		void hideShopList ()
		{
				//shopListContent.transform.position = new Vector3 (shopListContent.transform.position.x, 0, shopListContent.transform.position.z);
				StartCoroutine (MoveObject (shopList.transform, shopList.transform.position,
			                            new Vector3 (shopList.transform.position.x,
			             shopList.transform.position.y - 3700.0f, shopList.transform.position.z), 0.25f));
		}

		IEnumerator MoveObject (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
		{
				float i = 0.0f;
				float rate = 1.0f / time;
				while (i < 1.0f) {
						i += Time.deltaTime * rate;
						thisTransform.position = Vector3.Lerp (startPos, endPos, i);
						yield return 0; 
				}
				if (!shopIsShow)
						shopIsShow = true;
				else
						shopIsShow = false;
		}

		void SubmitScore ()
		{
				PlayGameServices.submitScore ("CgkItJD32NYKEAIQAQ", GameManager.cookiesTotal);
		}
}
