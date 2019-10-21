using UnityEngine;
using System.Collections;
using UnityEngine.VR;

[RequireComponent(typeof(CharacterController))]
public class MovementController : MonoBehaviour
{
	public static MovementController Instance;

	public static bool IsMoving = false;

	public float speed = 4.0F;
	public float rotateSpeed = 2.0F;
	public float rotateAngle = 20;

	public bool moveForward;
	Vector3 forward;
	CharacterController controllor;
	public static float curSpeed;
	private Transform vrHead;

	public float stripOne = 1f;
	public float stripTwo = 0.3f;

	void Start()
	{
		Instance = this;
		controllor = GetComponent<CharacterController>();
		vrHead = Camera.main.transform;
		IsMoving = false;
	}


	void Update()
	{
		if (Time.timeScale == 0)
			return;

       

        forward = vrHead.TransformDirection(Vector3.forward);
        Vector2 TouchAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

        if (TouchAxis.magnitude > 0.3f)
        {
            if (Mathf.Abs(TouchAxis.x) <= Mathf.Abs(TouchAxis.y))
            {
                curSpeed = speed * TouchAxis.y;
                controllor.SimpleMove(forward * curSpeed);
            }
        }

#if UNITY_EDITOR
        NormalController();
#endif
    }

    void NormalController()
	{
		forward = vrHead.TransformDirection(Vector3.forward);
		curSpeed = speed * Input.GetAxis("Vertical");
		controllor.SimpleMove(forward * curSpeed);
	}

	void OnDisable()
	{
		IsMoving = false;
	}
}
