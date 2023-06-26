using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public PlayerHealth dame;

    public Vector3 moveSpeed = new Vector3(0, 50, 0);
    public float timeToFade = 1f;

    public RectTransform textTransform;
    public TextMeshProUGUI textMeshPro;

    private float timeElapsed = 0f;
    private Color startColor;

    // Start is called before the first frame update
    void Awake()
    {
        textTransform = GetComponent<RectTransform>();
        textMeshPro = GetComponent<TextMeshProUGUI>();
        startColor = textMeshPro.color;  
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //textMeshPro.text = "-" + dame.damageEnemy;
        textTransform.position += moveSpeed * Time.deltaTime;
        timeElapsed += Time.deltaTime;
        
        if(timeElapsed < timeToFade)
        {
            float fadeAlpha = startColor.a * (1-(timeElapsed / timeToFade));
            textMeshPro.color = new Color(startColor.r, startColor.g, startColor.b, fadeAlpha);
            
        }
        if (timeToFade > timeElapsed)
        {
            //Destroy(gameObject);
        }
        
    }
}
