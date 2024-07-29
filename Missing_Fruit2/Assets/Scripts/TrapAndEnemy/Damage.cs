using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damageForce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        canAzalt(collision.gameObject);
        force(collision.gameObject);
        anim(collision.gameObject);

        }
    }
    void canAzalt(GameObject collision)
    {
        Health PlayerHealth = collision.gameObject.GetComponent<Health>();
        PlayerHealth.hitVoicePlay();
        PlayerHealth.lifeIndis--;
     
        
            }
    void force(GameObject collision)
    {
        Rigidbody2D PlayerRigibody = collision.gameObject.GetComponent<Rigidbody2D>();
        PlayerRigibody.velocity = new Vector2(PlayerRigibody.velocity.x, PlayerRigibody.velocity.y + damageForce);
    }
    void anim(GameObject collision)
    {
        Animator playerAnim = collision.GetComponent<Animator>();
        playerAnim.SetTrigger("isHit");
    }

}