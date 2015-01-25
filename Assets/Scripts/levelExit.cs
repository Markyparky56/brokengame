using UnityEngine;
using System.Collections;

public class levelExit : MonoBehaviour {

    globalvariables global;

	// Use this for initialization
	void Start () {
        global = GameObject.Find("gameManager").GetComponent<globalvariables>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
