﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{
    public float speed; 
    Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position=GetComponent<Rigidbody2D>().position;
        position.x=position.x+Time.deltaTime*speed; 
        rigibody2d.MovePosition(position); 
    }
}
