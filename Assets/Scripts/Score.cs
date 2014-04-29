using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{

		public tk2dTextMesh scoreText;
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

		public void setScore (int score)
		{

				scoreText.text = "+" + score.ToString ();
				scoreText.Commit ();
		}
}
