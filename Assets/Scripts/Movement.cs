using UnityEngine;using System.Collections;public class Movement : MonoBehaviour {	public float maxVelocity = 10.0f;	public float jumpVelocity = 10f;
    private float tempJumpVelocity;	private float maxSpeedTemp;    public GameObject dust;    public ParticleSystem dustSystem;	bool facingRight = true;	bool onGround;		Animator anim;		// Use this for initialization	void Start () 	{		anim = GetComponent<Animator>();        dust = GameObject.Find("runDust");        dustSystem = dust.GetComponent<ParticleSystem>();        maxSpeedTemp = maxVelocity;
        tempJumpVelocity = jumpVelocity;
        Physics2D.IgnoreLayerCollision(8, 9);	}		// Update is called once per frame	void FixedUpdate () 	{		float move = Input.GetAxis("Horizontal");		        if((move > 0.5 || move < -0.5) && onGround)        {            dustSystem.enableEmission = true;        }        else        {            dustSystem.enableEmission = false;        }		float animTrigger = move; //Changes the animation when the speed is greater than 0 																anim.SetFloat ("speed", Mathf.Abs (animTrigger));				anim.SetBool ("jumping", !onGround);					rigidbody2D.velocity = new Vector2(move * maxVelocity, rigidbody2D.velocity.y);				// Jumpy stuff		//rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpVelocity * vertical); 		if (Input.GetButton("Jump") && onGround)		{			rigidbody2D.AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);			onGround = false;		}        if (Input.GetButton("Sprint") && onGround) // Don't want sprinting mid-jump        {            maxVelocity = maxSpeedTemp * 1.5f;        }        else        {            if (onGround)            {                maxVelocity = maxSpeedTemp;            }        }						//the following all needs changed		if(move > 0 && !facingRight)		{			FlipFacing();		}		else if(move < 0 && facingRight)		{			FlipFacing();				}	}		void FlipFacing()	{		facingRight = !facingRight;		Vector3 charScale = transform.localScale;		charScale.x *= -1;		transform.localScale = charScale;        Vector3 dustRot = dust.transform.eulerAngles;         dustRot.y *= -1;        dust.transform.eulerAngles = dustRot;	}		void OnCollisionEnter2D(Collision2D collision)	{		if((collision.gameObject.name == "floor")           ||( collision.gameObject.name == "trapRock(Clone)"))		{			onGround = true;		}	}    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "pitLadder")
        {
            jumpVelocity *= 2;
        }
        else
        {
            jumpVelocity = tempJumpVelocity;
        }
    }	}