using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementkeys: MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator animator;

    // Start is called before the first frame update
    //void Start()
    //{
        //speed = 5.0f;
    //}

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");
	//if (Input.GetKey(KeyCode.A))
        //{
            //transform.Translate(Vector2.left * Time.deltaTime * speed);
       // }
        //if (Input.GetKey(KeyCode.D))
        //{ 
            //transform.Translate(Vector2.right * Time.deltaTime * speed);
        //}

    //void FixedUpdate()

    //{
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        

        


    //}

    animator.SetFloat("Horizontal", movement.x);
    animator.SetFloat("Horizontal", movement.y);
    animator.SetFloat("Speed", movement.sqrMagnitude);

    }		
}