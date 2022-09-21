using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestGiver : MonoBehaviour
{
    [SerializeField] private GameObject questGiverText;

    [SerializeField] private TMP_Text textComponent;

    [SerializeField] private string questText;
    [SerializeField] private string questCompleteText;
    [SerializeField] private int amountToCollect = 1;
    [SerializeField] private GameObject ladderToAppearWhenQuestIsComplete;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip pickUpClip;


    // Start is called before the first frame update
    void Start()
    {
        questGiverText.SetActive(false);

        textComponent.text = questText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == true)
        {
            if (collision.GetComponent<PlayerState>().appleAmount >= amountToCollect)
            {
                textComponent.text = questCompleteText;
                collision.GetComponent<PlayerQuest>().isQuestCompleted = true;
                ladderToAppearWhenQuestIsComplete.SetActive(false);
                audioSource.PlayOneShot(pickUpClip);
                print("Musik ska spelas nu");
            }
            else
            {
                textComponent.text = questText;
            }
            questGiverText.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") == true)
        {
            questGiverText.SetActive(false);
        }
    }
}
