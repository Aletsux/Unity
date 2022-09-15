using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerState : MonoBehaviour
{
    public int healthPoints = 2;
    public int initialHealthPoints = 2;
    private Animator _ar;
    public GameObject respawnPosition;
    void Start()
    {
        healthPoints = initialHealthPoints;
        _ar = GetComponent<Animator>();
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
