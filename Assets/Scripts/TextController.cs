﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TextController : MonoBehaviour
{
    public Text scoreValue; 
    private int score; 

    // Start is called before the first frame update
    void Start()
    {
        score=0; 
        scoreValue.text="Fixed:" + score.ToString();  
    

        
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        Projectile controller=Game
    }
}
