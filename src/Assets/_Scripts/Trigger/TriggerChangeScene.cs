﻿using UnityEngine;
using System.Collections;

public class TriggerChangeScene : MonoBehaviour {

	public string nameScene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

     
    void OnTriggerEnter(Collider other) 
    {
        Application.LoadLevel(nameScene);
    }
}
