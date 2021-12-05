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
    public int score;
    public GameObject robot1;
    public GameObject robot2;
    public GameObject robot3;
    public GameObject robot4;
    public GameObject robot5;
    public GameObject robot6;
    public GameObject robot7;
    public GameObject robot8;
    public GameObject robot9;



    private int c1;
    private int c2;
    private int c3;
    private int c4;
    private int c5;
    private int c6;
    private int c7;
    private int c8;
    private int c9;
    public Text win;

    // Start is called before the first frame update
    void Start()
    {
        win.text = "";
        score = 0;
        c1 = 0;
        c2 = 0;
        c3 = 0;
        c4 = 0;
        c5 = 0;
        c6 = 0;
        c7 = 0;
        c8 = 0;
        c9 = 0;




    }

    // Update is called once per frame


    void Update()
    {
        scoreValue.text = "Fixed:" + score.ToString();

        if (robot1.GetComponent<EnemyController>().broken == false && c1 == 0)
        {
            score += 1;
            c1 = 1;
        }
        if (robot2.GetComponent<EnemyController>().broken == false && c2 == 0)
        {
            score += 1;
            c2 += 1;
        }
        if (robot3.GetComponent<EnemyController>().broken == false && c3 == 0)
        {
            score += 1;
            c3 += 1;
        }
        if (robot4.GetComponent<EnemyController>().broken == false && c4 == 0)
        {
            score += 1;
            c4 += 1;
        }
        if (robot5.GetComponent<HardEnemyController>().broken == false && c5 == 0)
        {
            score += 1;
            c5 += 1;
        }
        if (robot6.GetComponent<HardEnemyController>().broken == false && c6 == 0)
        {
            score += 1;
            c6 += 1;
        }
        if (robot7.GetComponent<HardEnemyController>().broken == false && c5 == 0)
        {
            score += 1;
            c5 += 1;
        }
        if (robot8.GetComponent<HardEnemyController>().broken == false && c6 == 0)
        {
            score += 1;
            c6 += 1;
        }
        if (robot9.GetComponent<HardEnemyController>().broken == false && c6 == 0)
        {
            score += 1;
            c6 += 1;
        }


        if (score == 4)
        {
            win.text = "Talk To Jambi to see stage 2!";
        }
        if (score == 5)
        {
            win.text = "You Win!";
        }


        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("Stage 2");
        }






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





