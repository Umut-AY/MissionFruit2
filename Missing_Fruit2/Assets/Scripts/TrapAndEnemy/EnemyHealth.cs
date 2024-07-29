using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public float damageForce;
    public float health;
    public Animator animator;
    public GameObject GameObject;
    public GameObject deadthEffect;
    public AudioSource hitVoice;
    public AudioSource deathVoice;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canAzalt(collision.gameObject);
            force(collision.gameObject);

        }
    }
    void canAzalt(GameObject collision)
    {
        hitVoice.Play();
        animator.SetTrigger("hit");
        health--;
        if (health <= 0)
        {
            deathVoice.Play();
            StartCoroutine(ChecWaiting());
        }
    }
    void force(GameObject collision)
    {
        Rigidbody2D PlayerRigibody = collision.gameObject.GetComponent<Rigidbody2D>();
        PlayerRigibody.velocity = new Vector2(PlayerRigibody.velocity.x, PlayerRigibody.velocity.y + damageForce);
    }
    IEnumerator ChecWaiting()
    {
        Instantiate(deadthEffect, gameObject.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Destroy(this.GameObject);
    }
}
