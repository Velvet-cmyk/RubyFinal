using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed; 
    public bool vertical;
    public float changeTime=3.0f 
    Rigidbody2D rb; 
    float timer; 
    int direction=1; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    //this function is called once per frame
    void Update()
    {
        time -=Time.deltaTime;
        if (time<0)
        {
            direction=-direction;
            timer=changeTime;
        }
    }
    
    void FixedUpdate()
    {
        Vector2 position=rb.position;
        if(vertical)
        {
            position.y=position.y+Time.deltaTime*speed*direction;; 
        }
        else
        {
            {
                position.x=position.x+Time.deltaTime*speed*direction;; 
            }
        }
         
        rb.MovePosition(position); 
    }
}
