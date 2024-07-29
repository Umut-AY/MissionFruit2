using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public AudioSource hitVoice;
    public bool isDeadth=false;
    public GameObject[] lifes;
    public int lifeIndis = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeIndis < 0)
        {
            isDeadth=true;
        }
    }
    public void hitVoicePlay()
    {
        hitVoice.Play();
        lifes[lifeIndis].SetActive(false);
    }
}
