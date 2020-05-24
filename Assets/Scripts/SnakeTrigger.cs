using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeTrigger : MonoBehaviour {

	public void OnTriggerEnter2D (Collider2D other){
		if (GameManager.instance.Snake == true) 
			GameManager.instance.Killcount ++; //If enemy falls from view, registers as kill

		if (GameManager.instance.Enemies == GameManager.instance.Killcount)
			SceneManager.LoadScene("GameWon"); //When all enemies are defeated loads game won/credit scene
		
	}
}
