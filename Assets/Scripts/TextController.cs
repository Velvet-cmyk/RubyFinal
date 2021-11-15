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



    public Text win;

    // Start is called before the first frame update
    void Start()
    {
        win.text = "";
        score = 0;
        scoreValue.text = ("Score:" + score.ToString());




    }

    // Update is called once per frame


    void Update()
    {
        if (GetComponent<EnemyController>().broken == false)
        {
            score += 1;
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





