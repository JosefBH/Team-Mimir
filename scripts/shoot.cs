using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arrow;
    public GameObject player;
    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (player.GetComponent<SpriteRenderer>().flipX)
            {
                GameObject ar = GameObject.Instantiate(arrow);
                ar.GetComponent<Rigidbody2D>().velocity = Vector2.left * 50f;
            }
            else
            {


                GameObject ar = GameObject.Instantiate(arrow);
                ar.GetComponent<Rigidbody2D>().velocity = Vector2.right * 50f;
            }

        }

    }
}
