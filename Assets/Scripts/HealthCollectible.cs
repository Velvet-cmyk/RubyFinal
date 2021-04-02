using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour

{
    public AudioClip collectedClip;

    public Object effect;

     GameObject healthEffect;
    public ParticleSystem health;


    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();



        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {


                t=Instantiate(healthEffect); 

                controller.ChangeHealth(1);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);



            }


        }


    }
    void explode()
    {
        

    }
}
