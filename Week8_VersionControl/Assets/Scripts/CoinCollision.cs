using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    [SerializeField] private int coinValue;
    
    void OnTriggerEnter()
    {
        Scorekeeper.IncreaseScore1();
        Destroy(gameObject);
    }
}
