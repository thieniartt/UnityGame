using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Effect : MonoBehaviour
{

    [SerializeField] private AudioSource SlashSource;
    [SerializeField] private AudioSource HUrt;
    

    
    
    public void SlashSourceEffect()
    {
        SlashSource.Play();
    }

    public void Hurt_SourceEffect()
    {
        HUrt.Play();
    }
}
