using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (play ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator play(){
		yield return new WaitForSeconds(0.5f);
		Destroy (gameObject);
	}
}
