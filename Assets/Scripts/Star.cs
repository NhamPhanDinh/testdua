using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour
{
		private float angularRotation;
		private float spin = 80.0f;
		private float curentRotation = 20f;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				//Angular Transform
				float rotateSpeed = curentRotation * Time.deltaTime;
				transform.Rotate (new Vector3 (0, 0, -1) * rotateSpeed);
		}
}
