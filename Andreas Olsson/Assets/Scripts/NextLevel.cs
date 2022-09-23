using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int levelToLoad;
    [SerializeField] GameObject startPosition;
    public AudioSource doorSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            if(collision.GetComponent<PlayerQuest>() == true)
            {
                GameObserver.SaveCoinsToMemory(collision.GetComponent<CoinPicker>().Coin);
                doorSound.Play();
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }

}
