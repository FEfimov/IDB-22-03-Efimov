using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{

    public Text counterText;
    public CollisionScript cylScript;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counterText.text = "score: " + cylScript.count;
    }
}
