using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    public int Coin = 0;
    public TextMeshProUGUI textCoins;
    public AudioClip coinSound;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin ++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            textCoins.text = Coin.ToString();
            Destroy(other.gameObject);
        } 
               
    }


}
