using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHitBox : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Detected ob man getroffen wird
        if (collision.gameObject.tag == "ChargedAttack")
        {
            // Death animation Toggle
            animator.SetTrigger("Death");
        }
    }
}
