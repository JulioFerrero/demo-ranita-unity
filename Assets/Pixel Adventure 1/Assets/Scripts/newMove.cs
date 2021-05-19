using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newMove : MonoBehaviour
{

    public CharacterController2D controller;
    Animator run_Animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;


    // Update is called once per frame
    void Update()
    {
        run_Animator = GetComponent<Animator>();
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump")){
            jump = true;
        }

        if (Input.GetKey("d") || Input.GetKey("right")){
            run_Animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left")){
            run_Animator.SetBool("Run", true);
        } else {
            run_Animator.SetBool("Run", false);
        }

    }

    void FixedUpdate ()
    {

        controller.Move(horizontalMove * Time.deltaTime, false, jump);
        jump = false;

    }
}
