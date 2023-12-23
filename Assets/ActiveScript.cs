using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{
    public GameObject SphereObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.F))
        {
            //Debug.Log("Object is active");
            SphereObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Object is not active");
            SphereObject.SetActive(false);
        }
    }
}
