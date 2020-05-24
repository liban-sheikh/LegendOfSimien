using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {
	
	void Start () {
		StartCoroutine("LoadSimien");
	}

	IEnumerator LoadSimien() {
		yield return new WaitForSeconds (5);
		SceneManager.LoadScene ("Simien");
	}
}
