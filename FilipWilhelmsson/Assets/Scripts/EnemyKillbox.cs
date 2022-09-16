using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKillbox : MonoBehaviour
{

    GameObject gameObjectToKill;

    private void Start ()
    {
        gameObjectToKill = gameObject.transform.parent.gameObject;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == true)
        {
            if (collision.gameObject.GetComponent<PlayerMovement>().IsFalling() == true) 
            {
                gameObject.GetComponentInParent<EnemyBatMovement>().KillMe();
            }
        }
    }
}
