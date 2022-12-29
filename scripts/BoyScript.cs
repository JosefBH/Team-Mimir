using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyScript : MonoBehaviour

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
        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * 10;
            sr.flipX = false;
            anim.SetBool("isRun", true);
        }
        if (Input.GetKey("q"))
        {
            rb.velocity = Vector2.left * 10;
            sr.flipX = true;
            anim.SetBool("isRun", true);
        }
        if (Input.GetKey("z"))
        {
            rb.velocity = Vector2.up * 5  ;
            
            anim.SetBool("isRun", false);
        }

        if (Input.GetKey("s"))  
        {
            rb.velocity = Vector2.down * 5 ;

            anim.SetBool("isRun", false );
        }

        if (Input.GetKeyUp("d") || Input.GetKeyUp("q") || Input.GetKeyUp("z") || Input.GetKeyUp("s"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isRun", false);
        }

    }
}
