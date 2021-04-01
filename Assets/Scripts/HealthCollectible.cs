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
                GameObject projectileObject = Instantiate(projectilePrefab, rb.position + Vector2.up * 0.5f, Quaternion.identity);
                controller.ChangeHealth(1);
                Destroy(gameObject);
                controller.PlaySound(collectedClip);


            }




        }

    }

}