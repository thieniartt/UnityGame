using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject texxt;
    //public static BasicEnemyController bs;
    //public BasicEnemyController bs;
    public Slider HpUi;
    [SerializeField] private Rigidbody2D rb;
    
    public Animator anim;
    public int maxhealthPlayer = 100;
    public int healthPlayer = 100;
    public int damageEnemy = 1;
    //Start is called before the first frame update
    void Start()
    {
       //bs = GetComponent<BasicEnemyController> ();
       rb = GetComponent<Rigidbody2D>();
       HpUi.minValue = 0;
       HpUi.maxValue = maxhealthPlayer;
       HpUi.value = maxhealthPlayer;
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log("caho aus");
       if (healthPlayer > 0) anim.SetBool("isDie", false);
    }
        

    void OnTriggerEnter2D(Collider2D other) 
        {
            if (other.tag == "Enemy")
            {
                
                //BasicEnemyController bs = other.gameObject.GetComponent<BasicEnemyController>();
                if (healthPlayer > 0) 
                {
                    // Vector2 forceToAdd = new Vector2(rb.velocity.y-10, rb.velocity.y + 0.1f);
                    // rb.AddForce(forceToAdd, ForceMode2D.Impulse);
                    Instantiate(texxt);
                    
                    healthPlayer -= damageEnemy;
                    HpUi.value = healthPlayer;
                    anim.SetBool("indame", true);
                } 

                if (healthPlayer <=0)
                {
                    anim.SetBool("isDie", true);
                    
                }
                
            }
        }

        void OnTriggerExit2D(Collider2D other)
        {
            
            if (other.tag == "Enemy")
            {
                anim.SetBool("indame", false);
                
                
            }
        }
    

    
        
    
}
