﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TextController : MonoBehaviour
{
    public Text scoreValue; 
    public int score; 

    // Start is called before the first frame update
    void Start()
    {
        score=0; 
        scoreValue.text="Fixed:";  
    

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
