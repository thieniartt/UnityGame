using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSlideController : MonoBehaviour
{
    public PlayerController player;
    [Header("Wall Slide")]
    public float wallSlideSpeed;
    public bool canSWallSliding = true;
    public bool isWallSliding;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void CheckIfWallSliding()
    {
        player.anim.SetBool("isWallSliding", isWallSliding);
        if (!player.isGrounded) canSWallSliding = true;
        if (player.isTouchingWall && !player.isGrounded && canSWallSliding)
        {
            isWallSliding = true;
        }
        else
        {
            isWallSliding = false;
        }
        
        if (isWallSliding)
        {
            if(player.rb.velocity.y < -wallSlideSpeed)
            {
                player.rb.velocity = new Vector2(player.rb.velocity.x, -wallSlideSpeed);
            }
        }
    }
}
