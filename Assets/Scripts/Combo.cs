using UnityEngine;
using System.Collections;

public class Combo : MonoBehaviour
{
		public tk2dSprite comboSprite;
		private const float velocity = 300.0f;
		// Use this for initialization
		void Start ()
		{
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				float newY = transform.localPosition.y + velocity * Time.deltaTime;
				transform.localPosition = new Vector3 (transform.localPosition.x, newY, transform.localPosition.z);
				if (transform.position.y > 1280)
						Destroy (gameObject);
		}

		public void setSprite (int mode)
		{
				switch (mode) {
				case 1:
						setSpriteByIndex (1);
						break;
				case 2:
						setSpriteByIndex (2);
						break;
				case 3:
						setSpriteByIndex (3);
						break;
				case 5:
						setSpriteByIndex (5);
						break;
				case 10:
						setSpriteByIndex (10);
						break;
				case 20:
						setSpriteByIndex (20);
						break;
				case 30:
						setSpriteByIndex (30);
						break;
				case 40:
						setSpriteByIndex (40);
						break;
				case 50:
						setSpriteByIndex (50);
						break;
				}
		}

		void setSpriteByIndex (int index)
		{
				comboSprite.SetSprite ("x" + index.ToString ());
				comboSprite.Build ();
		}
}
