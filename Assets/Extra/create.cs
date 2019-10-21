using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject _sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void btnClicked()
    {
        print("btn clicked..");
        GameObject spt = Instantiate(_sprite,new Vector3(Random.Range(-5f,6f), Random.Range(-5f, 6f), 0),Quaternion.identity);
        spt.GetComponent<SpriteRenderer>().maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
    }
}
