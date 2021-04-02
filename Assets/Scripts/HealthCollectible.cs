using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour

{
    public AudioClip collectedClip;



    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();


        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {

                controller.healthEffect.Play();
                controller.ChangeHealth(1);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);
            }

        }
    }
}
