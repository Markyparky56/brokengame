using UnityEngine;
using System.Collections;

public class doorTrigger : MonoBehaviour {

    globalvariables global;
    public GameObject door;
    bool moveDoor = false;
    Animation anim;
    public GameObject exit;

	// Use this for initialization
	void Start () {
        global = GameObject.Find("gameManager").GetComponent<globalvariables>();
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(moveDoor)
        {
            // Trigger anim
            anim.wrapMode = WrapMode.Once;
            anim.Play();
            global.freezePlayer = true;
            moveDoor = false;
            // Enable exit
            Invoke("Exit", 2f); // Set time to length of animation
        }
	}
    void Exit()
    {
        Application.LoadLevel("Level2");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(global.doorLocked == false)
        {
            if(collision.gameObject.name == "bobController")
            {
                moveDoor = true;
            }
        }
    }
}
