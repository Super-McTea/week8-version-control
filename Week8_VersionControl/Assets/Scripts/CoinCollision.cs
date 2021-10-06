using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    [SerializeField] private int coinValue;
    
    void OnCollisionEnter(Collision col)
    {
        Scorekeeper.IncreaseScore(coinValue);
        Destroy(gameObject);
    }
}
