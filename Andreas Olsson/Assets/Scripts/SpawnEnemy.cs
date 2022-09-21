using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Instantiate(enemy, enemyPos.position, enemyPos.rotation);
            Destroy(gameObject);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
  
}
