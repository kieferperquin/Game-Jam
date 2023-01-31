using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 40f;
    float horizontalMove = 0f;
    bool jump;
    public CharacterController2D controller;
    bool stopMovement;
    int reverseDir = 1;

    // Update is called once per frame
    void Update()
    {
        if (!stopMovement)
        {
            horizontalMove = (Input.GetAxisRaw("Horizontal") * speed) * reverseDir;

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }
        else
        {
            horizontalMove = 0;
            jump = false;
        }    
    }
    void FixedUpdate()
    {

        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);

        jump = false;
    }

    public void PauseMoving()
    {
        stopMovement = true;
    }
    public void ResumeMoving()
    {
        stopMovement = false;
    }
    public void ReverseDirection()
    {
        reverseDir = -1;
    }
}