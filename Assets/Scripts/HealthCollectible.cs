﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour

{
    public AudioClip collectedClip;
    public GameObject healthEffect;
    public ParticleSystem health;










    void OnTriggerEnter2D(Collider2D other)
    {

        RubyController controller = other.GetComponent<RubyController>();





        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {
                GameObject healthEffectObject = Instantiate(healthEffect, transform.position, Quaternion.identity);






                controller.ChangeHealth(1);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);




            }


        }


    }

}
