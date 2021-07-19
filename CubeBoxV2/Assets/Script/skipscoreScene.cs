using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skipscoreScene : MonoBehaviour
{
    static int score = 0;
    public Text scoretext;
    
    
    // Start is called before the first frame update
    public void Start()
    {
        scoretext.text = score.ToString();
        
    }

    
    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
    }
}
