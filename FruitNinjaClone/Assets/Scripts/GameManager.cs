using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Score Elements")]
    public int score;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;

    [Header("Game Over")]
    public GameObject gameOverPanel;
    public Text gameOverPanelScoreText;
    public Text gameOverPanelHighScoreText;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
        GetHighScore();
    }

    private void GetHighScore()
    {
        highScore = PlayerPrefs.GetInt("Highscore");
        highScoreText.text = "Best: " + highScore;
    }

    public void IncreaseScore(int points)
    {
        score += points;
        scoreText.text = score.ToString();

        if(score > highScore)
        {
            PlayerPrefs.SetInt("Highscore", score);
            highScoreText.text = score.ToString();
        }
    }

    public void OnBombHit()
    {
        Time.timeScale = 0;

        gameOverPanelScoreText.text = "Score: " + score.ToString();
        gameOverPanelHighScoreText.text = "Best: " + highScore.ToString();
        gameOverPanel.SetActive(true);

        Debug.Log("Bomb hit");
    }

    public void RestartGame()
    {
        score = 0;
        scoreText.text = score.ToString();

        gameOverPanel.SetActive(false);

        foreach(GameObject g in GameObject.FindGameObjectsWithTag("Interactable"))
        {
            Destroy(g);
        }

        Time.timeScale = 1;
    }
}
