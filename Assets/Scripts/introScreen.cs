﻿using UnityEngine;
using System.Collections;

public class introScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetButton("Submit"))
	{
			Application.LoadLevel ("test");
	}
	
	}
}
