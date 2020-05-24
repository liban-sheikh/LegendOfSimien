using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

	void Start () {
		StartCoroutine("LoadCredits");
	}

	IEnumerator LoadCredits() {
		yield return new WaitForSeconds (5);
		SceneManager.LoadScene ("Credits");
	}
}
