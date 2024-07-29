using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float lifeTime;
    public bool left;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life();
        bullutTranslate();

    }
    void bullutTranslate()
    {
        if (left)
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }
    }
    void life()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
