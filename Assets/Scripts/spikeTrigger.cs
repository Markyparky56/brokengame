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
        Debug.Log(collision.gameObject.name);
        if (global.sceneLevel == globalvariables.level.Broken)
        {
            if (collision.gameObject.name == "bobController")
            {
                Destroy(invisibleWall);
            }
        }
    }
}
