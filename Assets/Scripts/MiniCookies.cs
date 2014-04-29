using UnityEngine;
using System.Collections;

public class MiniCookies : MonoBehaviour
{
		private float velocity;
		private float angularRotation;
		private float spin;
		public tk2dSprite miniCookiesSprite;
		// Use this for initialization
		void Start ()
		{
				float radius = Random.Range (0.08f, 0.2f);
				transform.localScale = new Vector3 (radius, radius, radius);
				transform.localPosition = new Vector3 (Random.Range (50.0f, 600.0f), 1280.0f, Random.Range (-1.5f, -0.5f));
				velocity = 220.0f;
				spin = 80;
				setColor (GameManager.currentColorMiniCookies);
		}
	
		// Update is called once per frame
		void Update ()
		{
				float newY = transform.localPosition.y - velocity * Time.deltaTime;
				transform.localPosition = new Vector3 (transform.localPosition.x, newY, transform.localPosition.z);
				//Angular Transform
				angularRotation += gameObject.transform.localRotation.z + spin * Time.deltaTime;
				gameObject.transform.localRotation = Quaternion.Euler (0, 0, angularRotation);
				if (transform.localPosition.y < -20.0)
						Destroy (gameObject);
		}

		public void setColor (int colorIndex)
		{
				miniCookiesSprite.SetSprite ("mainCookies_" + colorIndex.ToString ());
				miniCookiesSprite.ForceBuild ();

		}
}
