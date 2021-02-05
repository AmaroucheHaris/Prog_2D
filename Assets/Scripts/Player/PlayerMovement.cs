using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public float speed = 1.0f;
	private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        else if(Input.GetKey("d")){
        	movement = new Vector2(speed, 0);
        }
        else movement = new Vector2(0, 0);

       
        GetComponent<Rigidbody2D>().velocity = movement;

        //GetComponent<Rigidbody2D>().AddForce(movement);
    }
}
