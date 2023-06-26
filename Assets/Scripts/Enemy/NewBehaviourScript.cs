using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public PolygonCollider2D attackHit;
   public GameObject spell;
   public Transform[] spawnPosition;
   
   // public float minBounds = 10;
   // public float maxBounds = 20;

   public void attackSpell()
      {
         if (spell)
         {
            int i = Random.Range(0, spawnPosition.Length);
            Instantiate(spell,spawnPosition[i].position, spawnPosition[i].rotation);
         }
      } 

   public void Close()
      {
         attackHit.enabled = false;
      }

   public void Open()
      {
         attackHit.enabled = true;
      }
}
