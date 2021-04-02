using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour

{
    public AudioClip collectedClip;
    
    public ParticleSystem healthEffect; 


    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        


        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {
                other.Find("Health").GetComponent<ParticleSystem>().Play(); 

                controller.ChangeHealth(1);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);



            }

        }

    }
}
