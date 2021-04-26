using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;
    public AudioSource musicSource;

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


        if (enemy)
        {
            score = +1;
            scoreValue.text = "Fixed:" + score.ToString();
        }




    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
            

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            musicSource.Stop();
           

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
           
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            musicSource.Stop();
           

        }

    }

}





