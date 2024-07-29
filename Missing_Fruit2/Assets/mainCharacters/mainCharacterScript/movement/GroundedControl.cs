using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedControl : MonoBehaviour
{
    public Movement Movement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            Movement.isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            Movement.isGrounded = false;
        }
    }
} 
