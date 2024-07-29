using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public Health Health;
    public GameObject losePanel;
    public GameObject victory;
    public GameObject setting;
    public GameObject voiceSetting;
    public Slider musicSlider;
    public Slider effectSlider;
    public GameObject musicOn;
    public GameObject musicOff;
    public GameObject effectOn;
    public GameObject effectOff;
    public AudioSource musicSource;
    public AudioSource effectSource;
    public AudioSource effectSource2;
    public AudioSource effectSource3;
    public AudioSource effectSource4;
    public bool iswin;
    private void Start()
    {
        Time.timeScale = 1.0f;
        musicSlider.value= PlayerPrefs.GetFloat("musicSlider");
        effectSlider.value= PlayerPrefs.GetFloat("effectSlider");
    }
    // Update is called once per frame
    void Update()
    {
        isDeath();
        musicImageControl();
        effectImageControl();
        voiceControl();
        voiceSave();
        openVictory();


    }
    void isDeath()
    {
        if (Health.isDeadth == true)
        {
            Time.timeScale = 0f;
            losePanel.SetActive(true);
            voiceSetting.SetActive(true);
        }
       
    }

    void openVictory()
    {
        if (iswin)
        {
            Time.timeScale = 0f;
            victory.SetActive(true);
        }
    }
    void voiceControl()
    {
        musicSource.volume = PlayerPrefs.GetFloat("musicSlider");
        effectSource.volume = PlayerPrefs.GetFloat("effectSlider");
        effectSource2.volume = PlayerPrefs.GetFloat("effectSlider");
        effectSource3.volume = PlayerPrefs.GetFloat("effectSlider");
        effectSource4.volume = PlayerPrefs.GetFloat("effectSlider");
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



    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void continuee()
    {
        Time.timeScale = 1.0f;
        setting.SetActive(false);
        voiceSetting.SetActive(false);
    }
    public void goMainManu()
    {
        SceneManager.LoadScene("levelslect");
    }
    public void OpenSetting()
    {
        setting.SetActive(true);
        voiceSetting.SetActive(true);
    }
    

}
