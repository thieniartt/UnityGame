using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFallController : MonoBehaviour
{
    public PlayerController player;

    public int amountOfJumps = 2;
    public int amountOfJumpsLeft;

    [Header("Normal Jump")]
    private bool canNormalJump;
    public float jumpForce = 16.0f;
    private float jumpTimer = 2f;
    private bool isAttemptingToJump;
    private bool checkJumpMultiplier;

    [Header("Wall Jump")]
    public bool hasWallJumped;
    private float lastWallJumpDirection;
    public float wallJumpForce;
    public bool canWallJump;
    public Vector2 wallHopDirection;
    public Vector2 wallJumpDirection;
    public float wallJumpTimerSet = 0.15f;
    private float wallJumpTimer;

    private void Awake()
    {
        amountOfJumpsLeft = amountOfJumps;
    }

    void FixedUpdate()
    {
        CheckIfCanJump();
    }

    public void CheckJump()
    {
        
            if (Input.GetButtonDown("Jump"))
            {
                // if(!isGrounded && (isTouchingWall || isWallSliding))
                // {
                //     WallJump();
                    
                // }
                // else 
                if ((player.isGrounded || amountOfJumpsLeft != 0) && amountOfJumpsLeft != 0)
                {
                    NormalJump();
                }
                
                
            }
            
        
       
        // if(isAttemptingToJump)
        // {
        //     jumpTimer -= Time.deltaTime;
        // }

        // if(wallJumpTimer > 0)
        // {
        //     if(hasWallJumped && movementInputDirection == -lastWallJumpDirection)
        //     {
        //         rb.velocity = new Vector2(rb.velocity.x, 0.0f);
        //         hasWallJumped = false;
        //     }else if(wallJumpTimer <= 0)
        //     {
        //         hasWallJumped = false;
        //     }
        //     else
        //     {
        //         wallJumpTimer -= Time.deltaTime;
        //     }
        // }
    }

    private void NormalJump()
    {
        if (player.isGrounded)
        {
            player.rb.velocity = new Vector2(player.rb.velocity.x, jumpForce);
            amountOfJumpsLeft--;
        }
        
        if (!player.isGrounded)
        {
            player.rb.velocity = new Vector2(player.rb.velocity.x, jumpForce + 0.5f);
            amountOfJumpsLeft--;
        }
    }

    private void CheckIfCanJump()
    {
        if(player.isGrounded && player.rb.velocity.y <= 0.01f)
        {
            
            amountOfJumpsLeft = amountOfJumps;
        } 
        

        // if (isTouchingWall)
        // {
        //     checkJumpMultiplier = false;
        //     canWallJump = true;
        // } else canWallJump = false;

        // if(amountOfJumpsLeft <= 0)
        // {
        //     canNormalJump = false;
        // }
        // else
        // {
        //     canNormalJump = true;
        // }
      
    }
    
    // // private void Jump()
    // // {
    // //     if (canJump && !isWallSliding)
    // //     {
    // //         rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    // //         amountOfJumpsLeft--;
    // //     }
    // //     else if (isWallSliding && movementInputDirection == 0 && canJump) //Wall hop
    // //     {
    // //         isWallSliding = false;
    // //         amountOfJumpsLeft--;
    // //         Vector2 forceToAdd = new Vector2(wallHopForce * wallHopDirection.x * -facingDirection, wallHopForce * wallHopDirection.y);
    // //         rb.AddForce(forceToAdd, ForceMode2D.Impulse);
    // //         //Debug.Log("no");
    // //     }
    // //     else if((isWallSliding || isTouchingWall) && movementInputDirection != 0 && canJump)
    // //     {
    // //         isWallSliding = false;
    // //         amountOfJumpsLeft--;
    // //         Vector2 forceToAdd = new Vector2(wallJumpForce * wallJumpDirection.x * -facingDirection, wallJumpForce * wallJumpDirection.y);
    // //         rb.AddForce(forceToAdd, ForceMode2D.Impulse);
    // //         //Debug.Log("yes");
    // //     } 
    // //     // else if (isWallSliding && movementInputDirection != 0 && canJump)
    // //     // {
    // //     //     isWallSliding = false;
    // //     //     amountOfJumpsLeft--;
    // //     //     Vector2 forceToAdd = new Vector2(wallJumpForce * wallJumpDirection.x * movementInputDirection, wallJumpForce * wallJumpDirection.y);
    // //     //     rb.AddForce(forceToAdd, ForceMode2D.Impulse);
    // //     // } 
        
    // // }
}
