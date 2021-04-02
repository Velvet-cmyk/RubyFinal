using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour

{
    public AudioClip collectedClip;

    

     GameObject healthEffect;
    public ParticleSystem health;


    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        healthEffect=Resources.



        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {


                healthEffect=Instantiate(healthEffect); 

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
