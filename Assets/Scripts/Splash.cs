using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (playGame ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator playGame(){
		yield return new WaitForSeconds(1);
		Application.LoadLevel(1);
	}
}
