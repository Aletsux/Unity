using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerState : MonoBehaviour
{

    public int healthPoints = 2;
    public int initialHealthPoints =2;

    public int appleAmount = 1;

    [SerializeField] private GameObject respawnPosition;


    // Start is called before the first frame update
    void Start()
    {
        healthPoints = initialHealthPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoHarm(int doHarmByThisMuch)
    {
        healthPoints -= doHarmByThisMuch;
        if (healthPoints <= 0)
        {
            Respawn();
        }
    }

    public void Respawn ()
    {
        healthPoints = initialHealthPoints;
        gameObject.transform.position = respawnPosition.transform.position;

    }

    public void ApplePickup()
    {
        appleAmount++;
    }

    public void ChangeRespawnPosition(GameObject newRespawnPosition)
    {
        respawnPosition = newRespawnPosition;
    }
}
