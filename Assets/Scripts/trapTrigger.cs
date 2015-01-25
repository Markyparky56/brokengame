using UnityEngine;
using System.Collections;

public class trapTrigger : MonoBehaviour {

    public GameObject rock;
    public GameObject cover;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void breakTrap()
    {
        Destroy(cover);
        for (int i = 0; i < 5; ++i)
        {
            Instantiate(rock, new Vector3((52f + (0.25f * i)), 6f, 0.00f), new Quaternion(0, 0, 0, 0));
        }
        Object.Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("breakTrap", 0.35f);
        }
    }
}
