using UnityEngine;
using System.Collections;

public class ChocolateBar : MonoBehaviour
{

		private float timer;
		public tk2dUIProgressBar chocolateBar;
		private const int chocolateMax = 1000;
		public tk2dTextMesh timerText;
		// Use this for initialization
		void Start ()
		{
				timer = 0;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				timer += Time.deltaTime;
				timerText.text = ((int)timer).ToString ();
				timerText.Commit ();
				chocolateBar.Value = timer / chocolateMax;

		}
}
