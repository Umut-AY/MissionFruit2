using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFanForge : MonoBehaviour
{
    public float damageForce;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            force(collision.gameObject);
        }
    }
    void force(GameObject collision)
    {
        Rigidbody2D PlayerRigibody = collision.gameObject.GetComponent<Rigidbody2D>();
        PlayerRigibody.velocity = new Vector2(PlayerRigibody.velocity.x, PlayerRigibody.velocity.y + damageForce);
    }
}
