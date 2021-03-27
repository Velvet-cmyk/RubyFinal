using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed=3.0f; 
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

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position=rb.position;
        if(vertical)
        {
            position.y=position.y+Time.deltaTime*speed; 
        }
        else
        {
            {
                position.x=position.x+Time.deltaTime*speed; 
            }
        }
         
        rb.MovePosition(position); 
    }
}
