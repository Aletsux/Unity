using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_Apple : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip pickUpClip;

    private bool canPickUpCoin = true;


    private bool removeGameObject = false;
    private float timer = 0f;

    [SerializeField] private float timeBeforeDeletion = 1f;

    private void Update()
    {
        if(removeGameObject == true)
        {
            timer += Time.deltaTime;
            if(timer >= timeBeforeDeletion)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == true)
        {
            if (canPickUpCoin == true)
            {
                collision.GetComponent<PlayerState>().ApplePickup();
                animator.enabled = false;
                spriteRenderer.sprite = null;
                particles.Play();
                removeGameObject = true;
                canPickUpCoin = false;
                audioSource.pitch = Random.Range(0.9f, 1.1f);
                audioSource.PlayOneShot(pickUpClip);
            }
        }
    }


}
