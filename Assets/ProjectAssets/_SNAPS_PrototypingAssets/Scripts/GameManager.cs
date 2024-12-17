using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int points = 0;
    public int totalCollectibles; // Set this to the total number of collectibles in the scene

    public TextMeshProUGUI pointsText;
    public GameObject endingScreen;

    void Awake()
    {
        instance = this;
        pointsText.text = "Points: 0";
        endingScreen.SetActive(false); // Hide the ending screen initially
    }

    public void AddPoint()
    {
        points++;
        pointsText.text = "Points: " + points;

        if (points >= 26)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        endingScreen.SetActive(true);
        Time.timeScale = 0f; // Pause the game
    }
}