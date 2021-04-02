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
        Instantiate(healthEffect, new Vector3(0, 0, 0), Quaternion.identity);


        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {

                controller.ChangeHealth(1);

                controller.PlaySound(collectedClip);

                Destroy(gameObject);



            }

        }

    }
}
