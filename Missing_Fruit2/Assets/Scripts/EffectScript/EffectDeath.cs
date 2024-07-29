using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDeath : MonoBehaviour
{
    // Start is called before the first frame update
    public float DeathTime;

    // Update is called once per frame
    private void FixedUpdate()
    {
        DeathTime-=Time.deltaTime;
        if (DeathTime < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
