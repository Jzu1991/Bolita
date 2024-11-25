using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Coins : MonoBehaviour
{
    private int Coin = 0;
    public TextMeshProUGUI cointext;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin++;
            cointext.text = "Coins: " + Coin.ToString();
            Debug.Log("Monedas actuales= " + Coin);
            Destroy(other.gameObject);
        }
    }
}
