using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusGaze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void gazeEnter()
    {
        Debug.Log("Gaze entered...");
        transform.GetComponent<Renderer>().material.color = Color.red;
    }

    public void gazeExit()
    {
        Debug.Log("Gaze out...");
        transform.GetComponent<Renderer>().material.color = Color.white;
    }

    public void gazeClick()
    {
        Debug.Log("Gaze out...");
        transform.GetComponent<Renderer>().material.color = Color.green;
    }

}
