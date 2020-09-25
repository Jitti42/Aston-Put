using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject hudPanel;
    public GameObject resultPanel;
    //HUD
    public Text scoreText;
    private int score;

    //Result
    public Text currentScoreText;
    public Text bestScoreText;

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void ShowResult()
    {
        hudPanel.SetActive(false);
        resultPanel.SetActive(true);
        currentScoreText.text = score.ToString();

        int bestScore = PlayerPrefs.GetInt("BestScore");
        bestScoreText.text = bestScore.ToString();
        if(score>bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
            
        }
    }
    public void OnReplayClick()
    {
        int level = Application.loadedLevel;
        Application.LoadLevel(level);
    }
}
