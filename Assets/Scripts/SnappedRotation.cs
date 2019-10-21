using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class SnappedRotation : MonoBehaviour
{
	public static SnappedRotation instance;
    public float rotateAngle = 20;

    public float stripOne = 1f;
    public float stripTwo = 0.3f;
	private Transform vrHead;

	Vector3 forward = new Vector3();


	void Start()
	{
		instance = this;
        vrHead = Camera.main.transform;
	}

    void Update()
    {
		
        {
			//if (!vrHead == null)
            {
				//forward = vrHead.TransformDirection (Vector3.forward);
			} 
				
			Vector2 TouchAxis = OVRInput.Get (OVRInput.Axis2D.PrimaryTouchpad);
            if (TouchAxis.magnitude > 0.3f)
            {
                if (Mathf.Abs(TouchAxis.x) > Mathf.Abs(TouchAxis.y))
                {
                    if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
                    {
						
						print (OVRInput.Button.PrimaryTouchpad);
						print (TouchAxis.x);
						print (TouchAxis.y);
                        if (TouchAxis.x > 0)
                            transform.Rotate(0, rotateAngle, 0);
        
                        if (TouchAxis.x < 0)
                            transform.Rotate(0, -rotateAngle, 0);
                    }
                }
            }
        
            #if UNITY_EDITOR
                    NormalController();
            #endif
        }
		//else  if(VrSelector.instance.IsCardboard)
  //      {
  //          NormalController();
  //      }
    }

    void NormalController()
    {
        if (Input.GetButtonDown("Horizontal"))
            transform.Rotate(0, rotateAngle * Input.GetAxisRaw("Horizontal"), 0);
    }
}
