using System.Collections;
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
        health.GetComponent<ParticleSystem>();




        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {

                health.Play();





                controller.ChangeHealth(1);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);




            }


        }


    }

}
