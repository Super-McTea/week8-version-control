using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{

    private static int score;
    public static int Score
    {
        get
        {
            return score;
        }
    }

    private Scorekeeper instance;

    Scorekeeper Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    public static void IncreaseScore(int coinValue)
    {
        score += coinValue;
    }
}
