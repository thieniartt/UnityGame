using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashController : MonoBehaviour
{
    [Header("Dash")]
    private bool isDashing;
    public GameObject ef;
    public bool isTouchingWallDash;
    private bool canDash = true;
    private bool isDashed;
    public float dashingPower = 5f;
    public float dashingTime = 0.2f;
    public float dashingCooldown = 1f;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // public void EffectDash()
    // {
    //     //Vector2 point = new Vector2(transform.position.x-1f,transform.position.y);
    //     if (ef && transform.localScale.x < 0)
    //     {
    //         GameObject newGameObject = Instantiate(ef,new Vector2(transform.position.x+0.1f,transform.position.y),Quaternion.identity) as GameObject;
    //         newGameObject.transform.localScale = new Vector3 (0,-180,0);
    //     } 
    //     else if (ef && transform.localScale.x >= 0)
    //     {
    //         Instantiate(ef, new Vector2(transform.position.x-0.1f,transform.position.y),Quaternion.identity);
    //     }
    // }

    // public IEnumerator Dash()
    // {
    //     canDash = false;
    //     isDashed = true;
    //     float originalGravity = rb.gravityScale;
    //     rb.gravityScale = 0f;
    //     //Debug.Log("time");
    //     rb.velocity = new Vector2(transform.localScale.x * dashingPower,0f);
    //     yield return new WaitForSeconds(dashingTime);
    //     rb.gravityScale = originalGravity;
    //     isDashed = false;

    //     canDashAtk = true;
    //     yield return new WaitForSeconds(0.5f);
    //     canDashAtk = false;
        
    //     yield return new WaitForSeconds(dashingCooldown);
    //     canDash = true;
    // }

    // public void CheckDash()
    // {
    //     if (Input.GetKeyDown(KeyCode.LeftShift) && canDash && !isWallSliding && isGrounded)
    //     {
    //         isDashing = true;
    //         StartCoroutine(Dash());
    //         //if (isGrounded) dashingPower *= 2; else dashingPower /=2;
    //         //EffectDash();
    //     } else isDashing = false; 
    // }
}
