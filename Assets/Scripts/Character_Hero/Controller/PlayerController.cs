using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Component")]
    public Rigidbody2D rb;
    public Animator anim;
    //public ObjectCheck _obCheck;
    public RunController _run;
    public JumpFallController _jump;
    public DashController _dash;
    public AttackController _attack;
    public WallSlideController _wallslide;

    [Header("Check Wall")]
    public bool isTouchingWall;
    //public float wallCheckDistance;
    public Transform wallCheck;
    public float wallCheckRadius;

    [Header("Check Ground")]
    public bool isGrounded;
    public float groundCheckRadius;
    public Transform groundCheck;
    public LayerMask whatIsGround;

    private bool isFacingRight = true;
    public bool isruning;
    //public float movementInputDirection;
    
    

    
    
    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //_obCheck = GetComponent<ObjectCheck>();
        
        //sr = GetComponent<SpriteRenderer>();
        
        // amountOfJumpsLeft = amountOfJumps;
        // wallHopDirection.Normalize();
        // wallJumpDirection.Normalize();
        
        //Dash
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (isDashed)
        // {
        //     return;
        // }
        _run.ApplyMovement();
        _run.CheckInputRun();
        CheckMovementDirection();
        UpdateAnimations();
        _jump.CheckJump();
        // CheckIfCanJump();
        _wallslide.CheckIfWallSliding();
        // CheckDash();
        _attack.AttackOrDashAttack();
    
        
    }

    

    

    


    // public void StartAtk()
    // {
    //     Acttack();
    // }

    // public void BackToIdle()
    // {
    //     isAtk = false;
        
    // }

    private void FixedUpdate()
    {
        // if (isDashed)
        // {
        //     return;
        // }   
        
        CheckSurroundings();
    }

    

    //
    private void CheckMovementDirection()
    {
        if(isFacingRight && _run.movementInputDirection < 0)
        {
            Flip();
        }
        else if(!isFacingRight && _run.movementInputDirection > 0)
        {
            Flip();
        }

        if(rb.velocity.x != 0)
        {
            //canAtkRun = true;
            isruning = true;
        }
        else
        {
            //canAtkRun = false;
            isruning = false;
        }

        // if (canAtkRun) AttackRun();
    }

    private void UpdateAnimations()
    {
        anim.SetBool("isWalking", isruning);
        anim.SetBool("isGrounded",isGrounded);
        anim.SetFloat("yVelocity", rb.velocity.y);
        
        // anim.SetBool("isDashing", isDashing);
        // anim.SetBool("isDashAtk", isDashAtk);
        // anim.SetBool("isAtkRun", isAtkRun);
        // anim.SetBool("isFallAtk", isFallAtk);
    }

    

    private void Flip()
    {
        if ((isFacingRight && _run.movementInputDirection < 0f || !isFacingRight && _run.movementInputDirection > 0f))
        {
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
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
