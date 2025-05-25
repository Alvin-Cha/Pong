using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    int p1_scores;
    int p2_scores;

    // Public properties to get scores
    public int Player1Score => p1_scores;
    public int Player2Score => p2_scores;

    // Method to add score to Player 1
    public void AddScoreToPlayer1(int score)
    {
        p1_scores += score;
        Debug.Log("Player 1 Score: " + p1_scores);
    }

    // Method to add score to Player 2
    public void AddScoreToPlayer2(int score)
    {
        p2_scores += score;
        Debug.Log("Player 2 Score: " + p2_scores);
    }

    // Method to reset scores
    public void ResetScores()
    {
        p1_scores = 0;
        p2_scores = 0;
        Debug.Log("Scores Reset!");
    }

    // Optional: Display scores in Update for testing
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddScoreToPlayer1(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AddScoreToPlayer2(1);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScores();
        }
    }
}
