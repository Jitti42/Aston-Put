using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class scoremanage : MonoBehaviour
{
    
    public BonusScene scene;

    //HUD
    public Text scoreText;
    private int score;

   
    public void Checkscore()
    {
        score++;
        scoreText.text = score.ToString();


        if (score == 5)
        {
            scene.LoadScene();
            
        }


        /*else if(score == 6)
        {

            
        }*/
    }





}
