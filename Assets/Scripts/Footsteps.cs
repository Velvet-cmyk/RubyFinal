using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        RubyController controller = GetComponent<RubyController>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Controller)

    }
}
