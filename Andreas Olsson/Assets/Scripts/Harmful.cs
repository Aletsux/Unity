using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harmful : MonoBehaviour
{
    public AudioSource hurtSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerState>(out PlayerState playerTakesDamage))
        {
            hurtSound.Play();
            playerTakesDamage.TakeDamage(1);
        }
    }
}
