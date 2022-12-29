using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlScript : MonoBehaviour

{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            rb.velocity = Vector2.right * 10;
            sr.flipX = false;
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKey("left"))
        {
            rb.velocity = Vector2.left * 10;
            sr.flipX = true;
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKey("up"))
        {
            rb.velocity = Vector2.up * 5 ;

            anim.SetBool("isRunning", false);
        }

        if (Input.GetKey("down"))
        {
            rb.velocity = Vector2.down * 5 ;

            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyUp("right") || Input.GetKeyUp("left") || Input.GetKeyUp("down") || Input.GetKeyUp("up"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isRunning", false);
        }

    }
}
