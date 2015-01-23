using UnityEngine;using System.Collections;public class PlayerController : MonoBehaviour {    // Direction enumeration    enum Dir { Left, Right };    // Class Variables    private Transform trans;    Vector2 position;    public float velocity; // Change if sprinting
    float jumpVelocity;    //Dir direction;    bool crouched;    public float horizontal, vertical;
    bool onGround;
    GameObject heldItem;	void Start () {        // Initalise variables        position = new Vector2(0, 0);        trans = transform;        velocity = 2f;
        jumpVelocity = 5f;        //direction = Dir.Right;        crouched = false;
	}	void FixedUpdate () {        // Get movement axises        horizontal = Input.GetAxis("Horizontal");        vertical = Input.GetAxis("Vertical");        position = trans.position;	    // Jumpy stuff
        //rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpVelocity * vertical); 
        if (Input.GetButton("Jump") && onGround)
        {
            rigidbody2D.AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
            onGround = false;
        }        //if(Input.GetButton("Left"))
        //{
        //    direction = Dir.Left;
        //} 
        //else if(Input.GetButton("Right"))
        //{
        //    direction = Dir.Right;
        //}        // Check for sprinting        if(Input.GetButton("Sprint") && onGround) // Don't want sprinting mid-jump
        {
            velocity = 4f;
        }         else
        {
            if (onGround)
            {
                velocity = 2f;
            }
        }        // Move character horizontally        rigidbody2D.velocity = new Vector2(velocity * horizontal, rigidbody2D.velocity.y);	}    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "floor")
        {
            onGround = true;
        }
    }}