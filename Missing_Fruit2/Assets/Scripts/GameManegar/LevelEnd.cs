using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManeger GameManeger;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManeger.iswin = true;
            getlevelindex();
        }
    }
    public void getlevelindex()
    {
        int currentlevelIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentlevelIndex >= PlayerPrefs.GetInt("CurrentLevel"))
        {
            PlayerPrefs.SetInt("CurrentLevel", currentlevelIndex + 1);
        }
    }
}
