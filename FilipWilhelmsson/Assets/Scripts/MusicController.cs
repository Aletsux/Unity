using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private AudioClip Ambience;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = Ambience;
        audioSource.loop = true;
        audioSource.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
