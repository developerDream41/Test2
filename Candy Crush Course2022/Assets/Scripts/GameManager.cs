using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int score=0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("Score: "+ score);
    }

    public void GameOver()
    {
        CandySpawner.instance.StopSpawnCandy();
    }
}
