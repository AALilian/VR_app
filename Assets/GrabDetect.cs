using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.PlayerLoop;
// using UnityEngine.Events;

public class GrabDetect : MonoBehaviour
{
    
    public GameObject end_spotlight;
    public GameObject start_spotlight;
    public GameObject trigger_collider;

    public SpotLight spot;

    private bool first_time_picked_up = true;


    public void GrabObject()
    {
        //GetComponent<Renderer>().material.color = Color.red;

        if (first_time_picked_up)
        {
            end_spotlight.gameObject.SetActive(true);
            start_spotlight.gameObject.SetActive(false);
            trigger_collider.gameObject.SetActive(true);

            first_time_picked_up=false;
        }
        

    }

}
