using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{


    //Controls 

    public float speed;
    private Vector2 direction;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    private void Update()
    {

        TakeInput();
        Move();


    }

    //Allows movement and idle
    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if(direction.x != 0 || direction.y != 0)
        {
            SetAnimatorMovement(direction);

        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }

    }

    //Input Controls for Movement
    private void TakeInput()
    {
        direction = Vector2.zero;

        //right Direction 

        void Walk_Right()
        {
            animator.SetTrigger("MoveRight");
        }

        void IdleRight()
        {
            animator.SetTrigger("Idle_Right");
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector2.right;
            IdleRight();
            Walk_Right();
        }


        //left Direction

        void Walk_Left()
        {
            animator.SetTrigger("MoveLeft");
        }

        void IdleLeft()
        {
            animator.SetTrigger("Idle_Left");
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
            IdleLeft();
            Walk_Left();
        }
        

        //up = ClimbUp
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }

        //down = Climbdown
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }   



    }

    //Allows Movement 

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetLayerWeight(1, 1);
        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("yDir", direction.y);
        print(animator.GetFloat("xDir"));
    }


}
