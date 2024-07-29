using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.SceneManagement;

public class MainGameManeger : MonoBehaviour
{
   
    public Slider musicSlider;
    public Slider effectSlider;
    public GameObject musicOn;
    public GameObject musicOff;
    public GameObject effectOn;
    public GameObject effectOff;
    public AudioSource musicSource;

    private void Start()
    {
        Time.timeScale = 1.0f;
        musicSlider.value= PlayerPrefs.GetFloat("musicSlider");

    }
    // Update is called once per frame
    void Update()
    {
     
        musicImageControl();
        effectImageControl();
        voiceControl();
        voiceSave();



    }


  
    
    void voiceControl()
    {
        musicSource.volume = PlayerPrefs.GetFloat("musicSlider");
    }
    void voiceSave()
    {
        PlayerPrefs.SetFloat("musicSlider", musicSlider.value);
        PlayerPrefs.SetFloat("effectSlider", effectSlider.value);
    }
    void musicImageControl()
    {
        if (musicSlider.value == 0)
        {
            musicOff.SetActive(true);
            musicOn.SetActive(false);
        }
        else
        {
            musicOff.SetActive(false);
            musicOn.SetActive(true);
        }
    }
    void effectImageControl()
    {
        if (effectSlider.value == 0)
        {
            effectOff.SetActive(true);
            effectOn.SetActive(false);
        }
        else
        {
            effectOff.SetActive(false);
            effectOn.SetActive(true);
        }
    }



 
    public void exit()
    {
        Application.Quit();
    }
  
    public void goMainManu()
    {
        SceneManager.LoadScene("levelslect");
    }
  
    

}
