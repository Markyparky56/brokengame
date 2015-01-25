using UnityEngine;
using System.Collections;

public class chatTrigger : MonoBehaviour {

    public GameObject chatBubble;
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
        if(collision.gameObject.name == "bobController" && global.entranceTriggered == false)
        {
            Instantiate(chatBubble, new Vector3(-18.5f, 1.8f, 0f), new Quaternion(0,180,0,0));
            global.entranceTriggered = true;
            global.freezePlayer = true;
            Invoke("unfreeze", 5f);
        }
    }

    void unfreeze()
    {
        global.freezePlayer = false;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "bobController")
        {
            GameObject bubble = GameObject.Find("speechbubble(Clone)");
            Destroy(bubble);
        }
    }
}
