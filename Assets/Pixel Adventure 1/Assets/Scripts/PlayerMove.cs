using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Animator run_Animator;
    
    //Definim les variables runSpeed i jumpSpeed
    public float runSpeed = 2;
    public float jumpSpeed = 3;
    SpriteRenderer m_SpriteRenderer;
 
    // Start is called before the first frame update
    Rigidbody2D rb2d;
 
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();


    }
 
    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
 
        if (Input.GetKey("d") || Input.GetKey("right")){
            pos.x += runSpeed * Time.deltaTime;
            m_SpriteRenderer.flipX = false;
            run_Animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left")){
            pos.x -= runSpeed * Time.deltaTime;
            m_SpriteRenderer.flipX = true;
            run_Animator.SetBool("Run", true);
        } else {
            run_Animator.SetBool("Run", false);
        }
        if((Input.GetKey("w") || Input.GetKey("space")) && CheckGround.isGrounded){
	    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);

        }
        if(!CheckGround.isGrounded){
            run_Animator.SetBool("Jump", true);
        }else {
             run_Animator.SetBool("Jump", false);
        }
        

        transform.position = pos;
    }

}
