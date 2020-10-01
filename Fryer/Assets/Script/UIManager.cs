using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;

using System.Globalization;

using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public GameObject hudPanel;
    public GameObject resultPanel;
    public GameObject FacePanel;
    //HUD
    public Text scoreText;
    private int score;

    //Result
    public Text currentScoreText;
    public Text bestScoreText;

    //Face detect
    public string code;
    public InputField inputField;
    public Text popup;
    

    //pauseGame
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;

    public void OnSubmit()
     {
         code = inputField.text;
         Debug.Log(code);
         if (code == "1")
         {
            popup.text = "1";
         }
         else if (code == "0")
         {
            popup.text = "0";
         }
    }
    
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        
        if(score == 10)
        {
            FacePanel.SetActive(true);
            pause();
            OnSubmit();
            
        }
        
        
    }
    
    public void OneClick()
    {
        Resume();
        FacePanel.SetActive(false);
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
