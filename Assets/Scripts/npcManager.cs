using UnityEngine;
using System.Collections;

public class npcManager : MonoBehaviour {

    globalvariables global;
    public bool npcshid;

	// Use this for initialization
	void Start () {
        global = GameObject.Find("gameManager").GetComponent<globalvariables>();
        npcshid = false;
  	}
	
	// Update is called once per frame
	void Update () {
	    if(global.trapTriggered == true && npcshid == false)
        {
            foreach (Transform child in transform)
            {
                if (child.name != "GlitchyBob")
                {
                    Destroy(child.gameObject);
                }
                else
                {
                    foreach (Transform parts in child.transform)
                    {
                        if (parts.GetComponent<SpriteRenderer>() == null)
                        {
                            foreach (Transform features in parts.transform)
                            {
                                features.GetComponent<SpriteRenderer>().enabled = true;
                            }
                        }
                    }
                }
            }
        }
	}

    
}
