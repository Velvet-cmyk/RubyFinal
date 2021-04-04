using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour

{
    public AudioClip collectedClip;

    public ParticleSystem health = null;










    void OnTriggerEnter2D(Collider2D other)
    {

        RubyController controller = other.GetComponent<RubyController>();





        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {







                controller.ChangeHealth(1);
                Instantiate(health, transform.position, Quaternion.identity);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);




            }


        }


    }

}
