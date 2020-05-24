using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimienTrigger : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other){
			if (GameManager.instance.Simien == true) 
				SceneManager.LoadScene("GameOver"); //Game ends if player falls from view, load game over/credit scene
		Destroy (gameObject);
		}
}