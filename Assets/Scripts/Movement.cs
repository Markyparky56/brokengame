using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	public float maxVelocity = 10.0f;
	public float jumpVelocity = 10f;
	private float maxSpeedTemp;
	
	//this needs changed to right thumbstick
	bool facingRight = true;
	bool onGround;
	
	Animator anim;
	
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float move = Input.GetAxis("Horizontal");
		
		
		
		float animTrigger = move; //Changes the animation when the speed is greater than 0 
														
		anim.SetFloat ("speed", Mathf.Abs (animTrigger));
		
		anim.SetBool ("jumping", !onGround);
			
		rigidbody2D.velocity = new Vector2(move * maxVelocity, rigidbody2D.velocity.y);
		
		// Jumpy stuff
		//rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpVelocity * vertical); 
		if (Input.GetButton("Jump") && onGround)
		{
			rigidbody2D.AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
			onGround = false;
		}
		
//		if(Input.GetButton("Sprint") && onGround) // Don't want sprinting mid-jump
//		{
//			maxSpeed = maxSpeedTemp*1.5 ;
//		} 
//		else
//		{
//			if (onGround)
//			{
//				maxSpeed = maxSpeedTemp;
//			}
//		}
		
		
		//the following all needs changed
		if(move > 0 && !facingRight)
		{
			FlipFacing();
		}
		else if(move < 0 && facingRight)
		{
			FlipFacing();		
		}
	}
	
	void FlipFacing()
	{
		facingRight = !facingRight;
		Vector3 charScale = transform.localScale;
		charScale.x *= -1;
		transform.localScale = charScale;
	
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name == "floor")
		{
			onGround = true;
		}
	}
	
}
