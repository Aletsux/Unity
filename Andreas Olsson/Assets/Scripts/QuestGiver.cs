using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    [SerializeField] private GameObject QuestGiverText;
    [SerializeField] private Text textComponent;
    [SerializeField] private string questBegingText;
    [SerializeField] private string questIsCompleteText;
    [SerializeField] private int amountToCollect = 1;
    [SerializeField] private GameObject DoorToNextLevel;
    // Start is called before the first frame update
    void Start()
    {
        QuestGiverText.SetActive(false);
        textComponent.text = questBegingText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            QuestGiverText.SetActive(true);
        }
        if (collision.GetComponent<CoinPicker>().Coin >= amountToCollect)
        {
            textComponent.text = questIsCompleteText;
            collision.GetComponent<PlayerQuest>().isQuestComplete = true;
            DoorToNextLevel.SetActive(false);

        }
        else
        {
            textComponent.text = questBegingText;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            QuestGiverText.SetActive(false);
        }
    }
}
