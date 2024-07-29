using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Levelslectmenager : MonoBehaviour
{
    int levelIndex;
    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        levelIndex = PlayerPrefs.GetInt("CurrentLevel",1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < levelIndex; i++)
        {
            buttons[i].interactable |= true;
        }
      
      


    }
    private void FixedUpdate()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadscene(int levelindex)
    {
        SceneManager.LoadScene(levelindex);
    }
}
