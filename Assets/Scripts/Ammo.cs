using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        RubyController controller = other.GetComponent<RubyController>();





        if (controller != null)
        {
            controller.Reload(2);
            Destroy(gameObject);
        }
    }
}

