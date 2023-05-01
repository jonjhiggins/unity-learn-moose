using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int lives = 3;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        LogValues();
    }

    void LogValues()
    {
        if (lives <= 0)
        {
            Debug.Log("Game over!");
            return;
        }
        Debug.Log($"Lives {lives} | Score: {score}");
    }

    public void IncreaseScore()
    {
        score += 1;
        LogValues();
    }

    public void DecreaseLives()
    {
        lives -= 1;
        LogValues();
    }
}