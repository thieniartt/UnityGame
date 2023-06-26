using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunController : MonoBehaviour
{
    public PlayerController player;
    public WallSlideController wallslide;
    
    [Header("Run")]
    public float movementInputDirection;
    private int amountOfJumpsLeft;
    private int facingDirection = 1;
    public float airDragMultiplier = 0.95f;
    public float variableJumpHeightMultiplier = 0.5f;
    public float movementForceInAir;
    private bool canMove;
    private bool canFlip;
    private bool isFacingRight = true;
    private bool isWalking;
    //private bool isGrounded;
    public float movementSpeed = 4.0f;
    private float turnTimer;

    private void Awake() {
        player = GetComponent<PlayerController>();
        
    }
    public void CheckInputRun()
    {
        movementInputDirection = Input.GetAxisRaw("Horizontal");

        // if (Input.GetButtonDown("Jump"))
        // {
        //     CheckJump();
        // }
        

        // if (Input.GetButtonUp("Jump"))
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * variableJumpHeightMultiplier);
        // }

    }

    public void ApplyMovement()
    {
        if (!wallslide.isWallSliding)
        {
            player.rb.velocity = new Vector2(movementSpeed * movementInputDirection, player.rb.velocity.y);
        }
        // else if(!isGrounded && !isWallSliding && movementInputDirection != 0 && !isDashing)
        // {
        //     Vector2 forceToAdd = new Vector2(movementForceInAir * movementInputDirection, 0);
        //     rb.AddForce(forceToAdd);

        //     if(Mathf.Abs(rb.velocity.x) > movementSpeed)
        //     {
        //         rb.velocity = new Vector2(movementSpeed * movementInputDirection, rb.velocity.y);
        //     }
        // }
        // else if(!isGrounded && !isWallSliding && movementInputDirection == 0 && !isDashing)
        // {
        //     rb.velocity = new Vector2(rb.velocity.x * airDragMultiplier, rb.velocity.y);
        // }

    }
}
