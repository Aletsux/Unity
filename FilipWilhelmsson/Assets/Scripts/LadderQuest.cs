using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LadderQuest : MonoBehaviour
{

    [SerializeField] int levelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
           if (collision.GetComponent<PlayerQuest>().isQuestCompleted == true)
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
