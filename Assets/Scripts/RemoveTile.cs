using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTile : MonoBehaviour {

	void OnMouseDown(){
		if (GameManager.instance.RemoveTile == true) { //Remove tile on click
			Destroy (gameObject);
		}
	}
}
