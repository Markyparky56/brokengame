﻿using UnityEngine;
using System.Collections;

public class dustParticles : MonoBehaviour {

	// Use this for initialization
	void Start () {
        particleSystem.renderer.sortingLayerName = "particlelayer";
        particleSystem.renderer.sortingOrder = 5;
        Debug.Log("Particle system renderering on particlelayer");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
