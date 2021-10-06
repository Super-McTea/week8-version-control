using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text p1ScoreText;
    public Text p2ScoreText;

    private UIManager instance;

    UIManager Instance
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
    
    void Update()
    {
        p1ScoreText.text = string.Format("Player 1 Score: {0}", Scorekeeper.P1Score);
        p2ScoreText.text = string.Format("Player 2 Score: {0}", Scorekeeper.P2Score);
    }
}
