using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_CoinValue : MonoBehaviour
{
    private TMP_Text textComponent;
    private PlayerState playerState;

    void Start()
    {
        playerState = GameObject.Find("Player").GetComponent<PlayerState>();
        textComponent = gameObject.GetComponent<TMP_Text>();
    }

    void Update()
    {
        textComponent.text = playerState.appleAmount + "";
    }
}
