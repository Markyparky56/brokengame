using UnityEngine;
using System.Collections;

public class freezeTrigger : MonoBehaviour {

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
        if(collision.gameObject.name == "bobController")
        {
            global.freezePlayer = true;
            GameObject dialog = GameObject.Find("dialog 4");
            dialog.GetComponent<Animator>().SetBool("playDialog", true);
            Invoke("nextLevel", 29f);
        }
    }

    void nextLevel()
    {
        Application.LoadLevel("FInal Scene");
    }

}
