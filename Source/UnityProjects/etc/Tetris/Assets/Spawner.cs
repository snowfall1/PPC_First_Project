﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] groups;

	public void spawnNext(){
		int i = Random.Range (0, groups.Length);

		Instantiate (groups[i], transform.position, Quaternion.identity);
	}


	// Use this for initialization
	void Start () {
		spawnNext();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
