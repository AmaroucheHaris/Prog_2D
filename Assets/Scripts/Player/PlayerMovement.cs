using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public float speed = 1.0f;
	private Vector2 movement;
	private SpriteRenderer sp;
	private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
     	sp = GetComponent<SpriteRenderer>();
     	animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if(Input.GetKeyDown("q")){
        	movement = new Vector2(-speed, 0);
        }
        else if(Input.GetKeyDown("d")){
        	movement = new Vector2(speed, 0);

        }
        */

        if(Input.GetKey("q")){
        	movement = new Vector2(-speed, 0);
        	animator.SetBool("isMoving", true);
        	if(!sp.flipX){
        		sp.flipX = true;
        	}
        }
        else if(Input.GetKey("d")){
        	movement = new Vector2(speed, 0);
        	animator.SetBool("isMoving", true);
        	if(sp.flipX){
        		sp.flipX = false;
        	}
        }
        else {
        	movement = new Vector2(0, 0);
        	animator.SetBool("isMoving", false);
        }


       
        GetComponent<Rigidbody2D>().velocity = movement;

        //GetComponent<Rigidbody2D>().AddForce(movement);
    }
}
