using UnityEngine;
using System.Collections;

public class boulderTrigger : MonoBehaviour {

    public bool boulderTriggered;

	// Use this for initialization
	void Start () {
        boulderTriggered = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "bobController")
        {
            boulderTriggered = true;
            GameObject blocks = GameObject.Find("BLOCKS TO DESTROY");
            Destroy(blocks);
            GameObject oldDialog = GameObject.Find("Entrance");
            Destroy(oldDialog);
            GameObject dialog = GameObject.Find("dialog3");
            dialog.GetComponent<Animator>().SetBool("playDialog", true);
            //dialog.SetBool("playDialog", true);
            Invoke("stopDialog", 11f);
        }
    }

    void stopDialog()
    {
        GameObject dialog = GameObject.Find("dialog3");
        dialog.GetComponent<Animator>().SetBool("playDialog", false);
        GameObject wall = GameObject.Find("BLOCKS TO LOWER");
        Destroy(wall);
    }
}
