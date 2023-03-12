using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class endGame : MonoBehaviour
{
    public AudioSource AudioSource;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "keila")
        {
            AudioSource.Play();
        }

        
    }
}
