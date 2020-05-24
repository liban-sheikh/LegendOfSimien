using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public bool RemoveTile;

	public bool Simien;

	public bool Snake;

	public int Killcount = 0;

	public int Enemies;

	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		 Enemies = GameObject.FindGameObjectsWithTag("Snake").Length;

	}
}
