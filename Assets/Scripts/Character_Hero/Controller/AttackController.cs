using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public PlayerController player;
    [Header("Attack")]
    private bool isAtk;
    private bool canAtk;

    // [Header("Dash Attack")]
    // public bool isDashAtk = false;
    // public bool canDashAtk;

    // [Header("Attack Run")]
    // private bool isAtkRun;
    // public bool canAtkRun;

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // private void AttackRun()
    // {
    //     if (Input.GetKey(KeyCode.X) || Input.GetKeyDown(KeyCode.X) && !isFallAtk)
    //     {
    //         isAtkRun =true;
    //     } else isAtkRun =false;
    // }

    public void AttackOrDashAttack()
    {
        player.anim.SetBool("isAtk", isAtk);
        if ((Input.GetKey(KeyCode.X) || Input.GetKeyDown(KeyCode.X)) && player.isGrounded)
        {
            isAtk = true;
            //isDashAtk = false;
        } else isAtk =false;
        // if (Input.GetKeyDown(KeyCode.X) && canDashAtk)
        // {
        //     isAtk = false;
        //     isDashAtk = true;
        // } else isDashAtk = false;
    }
}
