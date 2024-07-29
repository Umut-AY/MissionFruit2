using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float runSpeed;
    public float jumpforce;
    public float doubleJumpforce;
    public float horizontal;
    public Rigidbody2D rb;    
    public SpriteRenderer SpriteRenderer;
    public bool isGrounded;
    bool isJumping=false;
    public Animator animator;
    public GameObject doubleJumpEffect;
    public AudioSource jumpSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumpControl();
        horizontalControl();
        flipControl();
        animControl();



    }

    void jumpControl()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + jumpforce);
                isJumping = true;
                jumpSource.Play();
            }
            else if (isJumping && !isGrounded)
            {
                animator.SetTrigger("doubleJump");
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + doubleJumpforce);
                isJumping = false;
                Instantiate(doubleJumpEffect, gameObject.transform.position, Quaternion.identity);
                jumpSource.Play();
            }

        }
    }

    void horizontalControl()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * runSpeed, rb.velocity.y);
    }

    void flipControl() 
    {
        if (rb.velocity.x<0)
        {
            SpriteRenderer.flipX = true;
        }
        else if (rb.velocity.x >0)
        {
            SpriteRenderer.flipX = false;
        }
    
    }
    void animControl() {
        if (!isGrounded)
        {
            animator.SetBool("isjump", true);
            animator.SetBool("isRun", false);
            animator.SetBool("isIdle", false);

        }
        else
        {
            animator.SetBool("isjump", false);
            animator.SetBool("isIdle", true);
            if (rb.velocity.x != 0)
            {
                animator.SetBool("isRun", true);
                animator.SetBool("isIdle", false);

            }
            else
            {
                animator.SetBool("isRun", false);
                animator.SetBool("isIdle", true);
            }
        }
    }
}
