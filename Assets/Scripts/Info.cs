using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour {

	void Start () {
		StartCoroutine("LoadInfo");
	}

	IEnumerator LoadInfo() {
		yield return new WaitForSeconds (5);
		SceneManager.LoadScene ("Info");
	}
}
