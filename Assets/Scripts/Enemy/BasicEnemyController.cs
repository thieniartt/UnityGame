using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyController : MonoBehaviour
{
    private Rigidbody2D Ghostrb;
    private Animator GhostAnim;
    [SerializeField] private  Transform AtkCheck;
    [SerializeField]
    public PolygonCollider2D attackHit;
    [SerializeField] private Transform explorationAreaCheck;
    [SerializeField]
    private GameObject player;
    public LayerMask whatIslayer;
    public float atkCheckRadius = 0.35f;
    public bool isAtkCheck;
    public bool isExplorationArea;
    public float arenaCheckDistance;
    public GameObject ghost;
    private bool facingRight = true;
    private float facingTime = 5f;
    private float nextFlip = 0f;
    private bool canFlip = true;
    public float ghostSpeed = 4f;
    private bool canRun=true;
    public bool isss =false;
    public bool canDame;
    public Vector2 kt;
    public float distance;

    public void Awake() 
    {
        GhostAnim = GetComponentInChildren<Animator>();
        Ghostrb = GetComponentInChildren<Rigidbody2D>();
        attackHit = GetComponentInChildren<PolygonCollider2D>();
        //player = GetComponent<PlayerController>();
    }

    public void Update()
    {
        //distance = player.transform.position.x - transform.position.x;
        //Debug.Log(distance1);
        if (Time.time > nextFlip)
        {
            nextFlip = Time.time + facingTime;
            Flip();
        }
        if (Mathf.Abs(player.transform.position.x - transform.position.x) < 5)
        {
            isAtkCheck = false;
        }
        
        if (isAtkCheck)
        {
            canFlip = false;
            canRun = false;
            GhostAnim.SetBool ("isRun", false);
            if (Mathf.Abs(player.transform.position.x - transform.position.x) > 20 && Mathf.Abs(player.transform.position.x - transform.position.x) <50)
                
                     GhostAnim.SetBool ("Knokback", true);
                    //GhostAnim.SetBool ("AtkSpell", true);
                 else 
                    GhostAnim.SetBool ("Knokback", true);
        }
            
        else if (!isAtkCheck)
        {
            canFlip = true;
            canRun = true;
            //GhostAnim.SetBool ("AtkSpell", true);
            GhostAnim.SetBool ("Knokback", false);
        }
        checking();
            

    }

    private void checking()
    {
        if (isExplorationArea)
        {
            //if (Time.time > 60 && ghostSpeed < 100) ghostSpeed *= 2;

            if (facingRight && player.transform.position.x < transform.position.x) 
                {
                    Flip();
                }
            if (!facingRight && player.transform.position.x > transform.position.x) 
                {
                    Flip();
                }

          
                
            if (canRun)
                {
                    if (!facingRight)
                        Ghostrb.velocity = new Vector2 (-1 * ghostSpeed, 0);
                    else if (facingRight)
                        Ghostrb.velocity = new Vector2 (1 * ghostSpeed, 0);

                    GhostAnim.SetBool ("isRun", true);
                }
                
        } else 
        {
            GhostAnim.SetBool ("isRun", false);
            canFlip = true;
        }
    }
     
    

    // void OnTriggerEnter2D(Collider2D other) 
    //     {
    //         if (other.tag == "Player")
    //         {
                

    //             if (facingRight && other.transform.position.x< transform.position.x) 
    //             {
    //                 Flip();
    //             } else if (!facingRight && other.transform.position.x > transform.position.x) 
    //             {
    //                 Flip();
    //             }
    //             canFlip = false;
                
    //         }
    //     }

    // void OnTriggerStay2D(Collider2D other)
    //     {
    //         canFlip = true;
            
    //         if (other.tag == "Player")
    //         {
    //             if (facingRight && other.transform.position.x< transform.position.x) 
    //             {
    //                 Flip();
    //             } else if (!facingRight && other.transform.position.x > transform.position.x) 
    //             {
    //                 Flip();
    //             }
    //             canFlip = false;
                
    //         }
    //         if (other.tag == "Player" && canRun)
    //         {
    //             if (!facingRight)
    //                 Ghostrb.AddForce (new Vector2 (-1, 0)* ghostSpeed);
    //             else if (facingRight)
    //                 Ghostrb.AddForce (new Vector2 (1, 0)* ghostSpeed);
    //             GhostAnim.SetBool ("isRun", true);
    //         }
    //     }

    // void OnTriggerExit2D(Collider2D other)
    //     {
            
    //         if (other.tag == "Player")
    //         {
    //             canFlip = true;
    //             Ghostrb.velocity = new Vector2(0,0);
    //             GhostAnim.SetBool ("isRun", false);
                
    //         }
    //     }
    


    private void Flip()
    {
        if (!canFlip) return;
        facingRight = !facingRight;
        Vector3 theScale = ghost.transform.localScale;
        theScale.x *= -1;
        ghost.transform.localScale = theScale;
    }
    
    public void CheckSurroundings()
    {
        isAtkCheck = Physics2D.OverlapCircle(AtkCheck.position, atkCheckRadius, whatIslayer);
        isss = attackHit.IsTouchingLayers(whatIslayer);
        isExplorationArea = Physics2D.OverlapBox(explorationAreaCheck.position, kt,0f,whatIslayer);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(AtkCheck.position, atkCheckRadius);
        Gizmos.DrawCube(transform.position, kt);

    }
    
    private void FixedUpdate()
    {
        CheckSurroundings();
    }
}
