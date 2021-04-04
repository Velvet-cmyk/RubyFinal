using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour

{
    public AudioClip collectedClip;
    public GameObject healthEffect;
    ParticleSystem health;










    void OnTriggerEnter2D(Collider2D other)
    {
        healthEffect.gameObject.SetActive(false);
        RubyController controller = other.GetComponent<RubyController>();





        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {

                healthEffect.gameObject.SetActive(true);





                controller.ChangeHealth(1);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);




            }


        }


    }

}
