using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoesDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<BossHealth>(out BossHealth playerDoesDamage))
        {
            playerDoesDamage.TakeDamage(1);
        }
    }
}
