using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    GameObject gameObjectToKill;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectToKill = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            Destroy(gameObjectToKill);
        }
    }
}
