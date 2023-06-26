using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damege =10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerHealth Damage = other.GetComponent<PlayerHealth>();
            if (Damage != null)
            {
                //Debug.Log("ho");
                //Damage.Hitt(damege);
            }
        }
    }
}
