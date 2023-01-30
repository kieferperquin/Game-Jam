using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] public float jumpForce = 400f;
    [SerializeField] Transform groundCheck;
    [SerializeField] private LayerMask whatIsGround;
    const float groundedRadius = .2f;
    private Rigidbody2D playerRigidBody;
    bool grounded;
    public UnityEvent onLandEvent;
    private Vector3 curVelocity = Vector3.zero;

    private void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();

        if (onLandEvent == null)
            onLandEvent = new UnityEvent();
    }

    // Update is called once per frame
    private void FixedUpdate()
	{
		bool wasGrounded = grounded;
	    grounded = false;

		// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
		// This can be done using layers instead but Sample Assets will not overwrite your project settings.
		Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, groundedRadius, whatIsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
			{
				grounded = true;

				if (!wasGrounded)
					onLandEvent.Invoke();
				//amount = 2;
			}
		}
	}

	public void Move(float move, bool jump)
    {
        if (grounded && jump)
        {
            // Add a vertical force to the player.
            grounded = false;
            playerRigidBody.AddForce(new Vector2(0f, jumpForce));
        }

        Vector3 targetVelocity = new Vector2(move * 10f, playerRigidBody.velocity.y);
        playerRigidBody.velocity = Vector3.SmoothDamp(playerRigidBody.velocity, targetVelocity, ref curVelocity, .05f);
    }
}
