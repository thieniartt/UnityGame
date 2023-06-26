using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public GameObject SoundOn;
    public GameObject BGMOn;
    public GameObject SoundOff;
    public GameObject BGMOff;
    [SerializeField] private AudioSource Music_Jungle;

    public void NewGame() 
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void Resume() 
    {
        SceneManager.LoadScene("SceneMenu"); 
    }

    public void OutGame()
    {
        Application.Quit();
    }

    public void Setting()
    {
        SceneManager.LoadScene("SceneSetting");
    }
    public void SoundtoOff()
    {
        SoundOff.SetActive(false);
        SoundOn.SetActive(true);
    }
    public void SoundtoOn()
    {
        
        SoundOff.SetActive(true);
        SoundOn.SetActive(false);
    }
    public void BGMtoOff()
    {
        Music_Jungle.Play();
        BGMOff.SetActive(false);
        BGMOn.SetActive(true);
    }
    public void BGMdtoOn()
    {
        Music_Jungle.Stop();
        BGMOff.SetActive(true);
        BGMOn.SetActive(false);
    }
}
