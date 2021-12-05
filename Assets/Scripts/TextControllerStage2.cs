using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextControllerStage2 : MonoBehaviour
{
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;
    public AudioSource musicSource;

    public Text scoreValue;
    public int score;

    public GameObject robot5;
    public GameObject robot6;
    public GameObject robot7;
    public GameObject robot8;
    public GameObject robot9;




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
        if (robot7.GetComponent<HardEnemyController>().broken == false && c7 == 0)
        {
            score += 1;
            c5 += 1;
        }
        if (robot8.GetComponent<HardEnemyController>().broken == false && c8 == 0)
        {
            score += 1;
            c6 += 1;
        }
        if (robot9.GetComponent<HardEnemyController>().broken == false && c9 == 0)
        {
            score += 1;
            c6 += 1;
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





