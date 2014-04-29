using UnityEngine;
using System.Collections;

public class CookiesBar : MonoBehaviour
{

		public tk2dUIProgressBar cookiesBar;
		public const float cookiesMax = 1000.0f;
		// Use this for initialization
		void Start ()
		{
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				cookiesBar.Value = (float)GameManager.cookiesTotal / (float)cookiesMax;
		}
}
