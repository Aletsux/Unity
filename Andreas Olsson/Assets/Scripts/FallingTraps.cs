using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTraps : MonoBehaviour
{
    Rigidbody2D _rb;
    public AudioSource smashSound;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
            _rb.isKinematic = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"));

        if (collision.gameObject.CompareTag("Plattform"))
        {
            smashSound.Play();
        }
    }
}
