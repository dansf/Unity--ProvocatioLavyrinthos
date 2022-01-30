using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0, coins = 0;
    private bool isKey = false;

    [Header("Key Settings")]
    [SerializeField] GameObject gateKey;

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit") && 
           (!other.gameObject.CompareTag("Coin")) &&     
           (!other.gameObject.CompareTag("Scenario")) &&
           (!other.gameObject.CompareTag("Key")) &&
           (!other.gameObject.CompareTag("Exit")))
        {
            hits++;
            Debug.Log("You bummped in something.");
        }
        else if (other.gameObject.CompareTag("Coin"))
        {
            coins++;
            Destroy(other.gameObject);
            Debug.Log("You got a coin.");
        }
        else if (other.gameObject.CompareTag("Key"))
        {
            isKey = true;
            Destroy(other.gameObject);
            openTheGateKey();
            Debug.Log("Exit open.");
        }
        else if (other.gameObject.CompareTag("Exit"))
        {
            Debug.Log("You finish the level.");
            return;
        }
    }

    private void openTheGateKey()
    {
        if(isKey) 
        Destroy(gateKey);
    }
}