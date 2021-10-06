using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{

    public static int pointsPerPickup = 10;
    private static int p1Score;
    public static int P1Score
    {
        get
        {
            return p1Score;
        }
    }
    private static int p2Score;
    public static int P2Score
    {
        get
        {
            return p2Score;
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

    public static void IncreaseScore1()
    {
        p1Score += pointsPerPickup;
    }

    public static void IncreaseScore2()
    {
        p2Score += pointsPerPickup;
    }
}
