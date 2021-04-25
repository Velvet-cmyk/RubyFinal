using System.Collections;
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
        score = 0;
        scoreValue.text = "Fixed:" + score.ToString();



    }

    // Update is called once per frame
    void OnCollisionEnter2D()
    {
        Projectile controller = GetComponent<Projectile>();

        EnemyController enemy = GetComponent<EnemyController>();


        if (controller.GetComponent<Projectile>())
        {
            score = +1;
            scoreValue.text = "Fixed:" + score.ToString();
        }




    }

}





