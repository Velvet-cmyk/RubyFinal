using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour

{
    public AudioClip collectedClip;
    public GameObject healthEffect;










    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        healthEffect.SetActive(false);




        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {

                healthEffect.SetActive(true);





                controller.ChangeHealth(1);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);




            }


        }


    }

}
