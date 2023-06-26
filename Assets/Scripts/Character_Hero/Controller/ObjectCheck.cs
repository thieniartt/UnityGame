using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCheck : MonoBehaviour
{
    [Header("Check Wall")]
    public bool isTouchingWall;
    //public float wallCheckDistance;
    public Transform wallCheck;
    public float wallCheckRadius;

    [Header("Check Ground")]
    public bool isGrounded = false;
    public float groundCheckRadius;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    
    // Start is called before the first frame update
    // void FixedUpdate()
    // {
    //     CheckSurroundings();
    // }

    public void CheckSurroundings()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        isTouchingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius,whatIsGround);

        //isTouchingWallDash = Physics2D.Raycast(walldashCheck.position, transform.right,wallCheckDistance,whatIsGround );
        //iscandash = Physics2D.OverlapCircle(checkcandash.position, groundCheckRadius, whatIsGround);
    }


    
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        Gizmos.DrawWireSphere(wallCheck.position, wallCheckRadius);

        //Gizmos.DrawLine(wallCheck.position, new Vector3(wallCheck.position.x + wallCheckDistance, wallCheck.position.y, wallCheck.position.z));
    }

}
