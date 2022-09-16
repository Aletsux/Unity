using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiHealth : MonoBehaviour
{
    public PlayerState playerState;
    int playerHealthPoints;
    private Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        playerHealthPoints = playerState.initialHealthPoints;
        slider = gameObject.GetComponent<Slider>();
        slider.wholeNumbers = true;
        slider.maxValue = playerHealthPoints;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = playerState.initialHealthPoints;
    }
}
