using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer sR;
    public  float speed;
    public float waitTime;
    public Transform[] movingspot;
    private float waitTime2;
    private int i;
    private Vector2 currentPos;


    // Start is called before the first frame update
    void Start()
    {
        currentPos = transform.position;
        waitTime2 = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ChecWaiting());
        setLocation();
        setPosition();

    }
    void setLocation()
    {
        transform.position = Vector2.MoveTowards(transform.position, movingspot[i].transform.position, speed * Time.deltaTime);
    }
    void setPosition()
    {
        if (Vector2.Distance(transform.position, movingspot[i].transform.position) < 0.01f)
        {
            if (waitTime <= 0)
            {
                anim.SetBool("run",true);
                if (movingspot[i] != movingspot[movingspot.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                waitTime = waitTime2;
            }
            else
            {
                anim.SetBool("run", false);
                waitTime -= Time.deltaTime;
            }
        }
    }

    IEnumerator ChecWaiting()
    {
        currentPos = transform.position;
        yield return new WaitForSeconds(0.5f);
        if (transform.position.x > currentPos.x)
        {
            sR.flipX = true;
        }
        else if (transform.position.x < currentPos.x)
        {
            sR.flipX = false;
        }
    }
     
     





}
