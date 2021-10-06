using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

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
        scoreText.text = string.Format("Score: {0}", Scorekeeper.Score);
    }
}
