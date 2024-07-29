using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farawayEnemyAttack : MonoBehaviour
{

    public Animator anim;
    public float waitTime;
    private float waitTime2;
    // Update is called once per frame
    private void Start()
    {
        waitTime2 = waitTime;
    }
    void Update()
    {
        attackTime();
    }
    void attackTime()
    {
            
            if (waitTime <= 0)
            {
            anim.SetTrigger("isHit");
            waitTime = waitTime2;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
    }
}


