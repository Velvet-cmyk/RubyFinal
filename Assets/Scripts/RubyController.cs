﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RubyController : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth;
    public float speed = 3.0f;
    public float timeInvincible = 2.0f;
    public int health { get { return currentHealth; } }
    bool isInvincible;
    float invincibleTimer;
    Rigidbody2D rb;
    float horizontal;
    float vertical;
    Animator anim;
    Vector2 lookDirection = new Vector2(1, 0);
    public GameObject projectilePrefab;
    AudioSource audioSource;
    public ParticleSystem healthEffect;

    public AudioClip hitClip;
    public Text score;
    private int scoreValue;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        audioSource = GetComponent<AudioSource>();
        scoreValue = 0;




    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            RaycastHit2D hit = Physics2D.Raycast(rb.position + Vector2.up * 0.2f,
            lookDirection, 1.5f, LayerMask.GetMask("NPC"));
            if (hit.collider != null)
            {
                NonPlayerCharacter character = hit.collider.GetComponent<NonPlayerCharacter>();
                if (character != null)
                {
                    character.DisplayDialog();
                }
            }
        }
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(horizontal, vertical);
        if (!Mathf.Approximately(move.x, 0.0f) ||
        !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
        anim.SetFloat("Look X", lookDirection.x);
        anim.SetFloat("Look Y", lookDirection.y);
        anim.SetFloat("Speed", move.magnitude);

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Launch();
        }
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }

    }
    void FixedUpdate()
    {
        Vector2 position = rb.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        rb.MovePosition(position);
    }
    public void ChangeHealth(int amount)
    {

        if (amount < 0)
        {
            anim.SetTrigger("Hit");
            if (isInvincible)
                return;
            isInvincible = true;
            invincibleTimer = timeInvincible;
            PlaySound(hitClip);
        }
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);

        if (amount > 0)
        {
            healthEffect.Play();
        }

    }

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rb.position + Vector2.up * 0.5f, Quaternion.identity);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(lookDirection, 300);
        
        anim.SetTrigger("Launch");

        
    }

}
