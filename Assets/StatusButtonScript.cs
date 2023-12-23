using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusButtonScript : MonoBehaviour
{
    public GameObject SphereObject;

    void Start()
    {
        
    }

    public void ButtonInteraction()
    {
        if(SphereObject.active == false)
        {
            Debug.Log("Sphere is inactive");
        }
        else
        {
            Debug.Log("Sphere is active");
        }
    }
    void FixedUpdate()
    {
        
    }
}
