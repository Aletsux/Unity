using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerState : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 3f;
    public AudioSource hurtSound;

    private Animator _ar;
    public GameObject respawnPosition;
    void Start()
    {
        health = maxHealth;
        _ar = GetComponent<Animator>();
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        hurtSound.Play();

        if (health <= 0)
        {
            Destroy(gameObject);
            RestartLevel();
        }
    }

    public void Respawn()
    {
        gameObject.transform.position = respawnPosition.transform.position;
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
