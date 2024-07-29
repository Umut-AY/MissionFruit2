using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
    public float speed;
    public float waitTime;
    public Transform[] movingspot;
    float waitTime2;
    private int i=0;
    //private Vector2 currentPos;


    // Start is called before the first frame update
    void Start()
    {
        waitTime2 = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        setLocation();
        setPosition();


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
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
                waitTime -= Time.deltaTime;
            }
        }
    }


}
