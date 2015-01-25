using UnityEngine;
using System.Collections;

public class killTrigger : MonoBehaviour {

    globalvariables global;

	// Use this for initialization
	void Start () {
        global = GameObject.Find("gameManager").GetComponent<globalvariables>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        global.freezePlayer = true;
        GameObject.Find("bobController").GetComponent<Animator>().SetBool("dead", true);
        Invoke("endGame", 2.1f);
    }

    void endGame()
    {
        Application.Quit();
    }
}
