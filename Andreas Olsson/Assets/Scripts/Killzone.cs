using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            RestartLevel();
        }
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene("GameOver");
    }
}
