using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pboy : MonoBehaviour
{
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    public SpriteRenderer sr1;
    public SpriteRenderer sr2;
    public Animator anim1;
    public Animator anim2;



    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb1.velocity = Vector2.right * 10;
            sr1.flipX = false;
            anim1.SetBool("isRunning", true);
        }
        if (Input.GetKey("q"))
        {
            rb1.velocity = Vector2.left * 10;
            sr1.flipX = true;
            anim1.SetBool("isRunning", true);
        }
        if (Input.GetKey("z"))
        {
            rb1.velocity = Vector2.up * 10;
        }
        if (Input.GetKeyUp("d") ||  Input.GetKeyUp("q") ||  Input.GetKeyUp("z"))
        {
            rb1.velocity = Vector2.zero;
            anim1.SetBool("isRunning", false);
        }


        if (Input.GetKey("right"))
        {
            rb2.velocity = Vector2.right * 10;
            sr2.flipX = false;
            anim2.SetBool("isRunning", true);
        }
        if (Input.GetKey("left"))
        {
            rb2.velocity = Vector2.left * 10;
            sr2.flipX = true;
            anim2.SetBool("isRunning", true);
        }
        if (Input.GetKey("up"))
        {
            rb2.velocity = Vector2.up * 10;
        }
        if (Input.GetKeyUp("left") ||  Input.GetKeyUp("right")  || Input.GetKeyUp("up"))
        {
            rb2.velocity = Vector2.zero;
            anim2.SetBool("isRunning", false);
        }



        
    }






}