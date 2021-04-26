using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Projectile : MonoBehaviour
{
    Rigidbody2D rb;
    public Text scoreValue;
    private int score;




    void Start()
    {

    }


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rb.AddForce(direction * force);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();

        if (e != null)
        {
            e.Fix();
            score = +1;
            scoreValue.text = "Fixed:" + score.ToString();

        }


        Destroy(gameObject);

        HardEnemyController f = other.collider.GetComponent<HardEnemyController>();

        if (f != null)
        {
            f.Fix();

        }


        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }
}
