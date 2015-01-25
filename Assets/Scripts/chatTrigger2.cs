using UnityEngine;
using System.Collections;

public class chatTrigger2 : MonoBehaviour {

    public GameObject chatBubble;
    globalvariables global;
    bool talked = false;

	// Use this for initialization
	void Start () {
        global = GameObject.Find("gameManager").GetComponent<globalvariables>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (global.trapTriggered == true && talked == false)
        { 
            Instantiate(chatBubble, new Vector3(-28.0f, 1.8f, 0), new Quaternion(0, 0, 0, 0));
            global.freezePlayer = true;
            Invoke("unfreeze", 5f);
            talked = true;
            global.doorLocked = false;
        }
    }

    void unfreeze()
    {
        global.freezePlayer = false;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "bobController")
        {
            GameObject bubble = GameObject.Find("speechbubble(Clone)");
            Destroy(bubble);
        }
    }
}
