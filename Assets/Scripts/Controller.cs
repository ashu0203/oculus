using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
     RaycastHit hit;

    // Update is called once per frame
    void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            transform.GetComponent<LineRenderer>().SetPosition(1, new Vector3(0, 0, hit.distance));
            //if(rayca)
            //transform.GetComponent<LineRenderer>().SetPosition(1, new Vector3(0, 0, Vector3.Distance(transform.position,hit.collider.transform.position)));
        }
        //else if (CanvasRenderer.)
        //{ }
        else
        {
            transform.GetComponent<LineRenderer>().SetPosition(1, new Vector3(0, 0, .5f));
        }
    }
}
