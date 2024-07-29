using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.SceneManagement;

public class LevelGameManeger1 : MonoBehaviour
{
   
    public AudioSource musicSource;

    private void Start()
    {
        Time.timeScale = 1.0f;
     
    }
    // Update is called once per frame
    void Update()
    {

        voiceControl();


    }


    void openVictory()
    {
     
    }
    void voiceControl()
    {
        musicSource.volume = PlayerPrefs.GetFloat("musicSlider");
     
    }

   
  



  
    

}
