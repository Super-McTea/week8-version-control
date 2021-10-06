using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
