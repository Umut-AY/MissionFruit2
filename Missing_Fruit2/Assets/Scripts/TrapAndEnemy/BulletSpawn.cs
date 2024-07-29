using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject Bullet;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Instantiate(Bullet,transform.position,Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
