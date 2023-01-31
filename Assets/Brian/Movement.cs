using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 40f;
    float horizontalMove = 0f;
    bool jump;
    public CharacterController2D controller;
    public GameObject anim;
    bool stopMovement;
    int reverseDir = 1;

    float faceDir;
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

        anim.GetComponent<Animator>().SetBool("IsGrounded", controller.GetComponent<CharacterController2D>().GetGrounded());
        faceDir = Input.GetAxisRaw("Horizontal") * reverseDir;
        anim.GetComponent<Animator>().SetFloat("Dir", faceDir);

        if (faceDir == -1)
        {
            anim.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (faceDir == 1)
        {
            anim.GetComponent<SpriteRenderer>().flipX = false;
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
    public bool WinCondition()
    {
        if (reverseDir == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}