using UnityEngine;
using System.Collections;

public class spikeTrigger : MonoBehaviour {

    public GameObject invisibleWall;
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
        //Debug.Log(collision.gameObject.name);
        if (global.sceneLevel == globalvariables.level.Broken)
        {
            if (collision.gameObject.name == "bobController" && global.trapTriggered == false)
            {
                Destroy(invisibleWall);
                global.trapTriggered = true;
                global.freezePlayer = true;
                GameObject.Find("Dialog2").GetComponent<Animator>().SetBool("playDialog", true);
                Invoke("unfreeze", 14f);
            }
        }
    }

    void unfreeze()
    {
        global.freezePlayer = false;
        GameObject.Find("Dialog2").GetComponent<Animator>().SetBool("playDialog", false);

    }
}
