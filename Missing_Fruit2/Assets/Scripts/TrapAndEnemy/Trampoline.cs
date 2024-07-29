using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float damageForce;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            force(collision.gameObject);
            animator.SetTrigger("ishit");
        }
    }
    void force(GameObject collision)
    {
        Rigidbody2D PlayerRigibody = collision.gameObject.GetComponent<Rigidbody2D>();
        PlayerRigibody.velocity = new Vector2(PlayerRigibody.velocity.x, PlayerRigibody.velocity.y + damageForce);
    }
}

