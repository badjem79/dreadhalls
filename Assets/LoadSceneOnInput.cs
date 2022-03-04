﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	public string sceneName;
	public bool destroyStatic = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Submit") == 1) {
			if (destroyStatic) {
				Destroy(DontDestroy.instance.gameObject);
			}
			SceneManager.LoadScene(sceneName);
		}
	}
}
