using UnityEngine;

public class HeadInUnity : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3[] mousePos;

    public GameObject pointer;
    [Range (0.1f,0.4f)]
    public float Senstivity=0.2f;

    private void Start()
    {
        mousePos = new Vector3[2];
#if UNITY_EDITOR
        pointer.SetActive(true);
#else
        pointer.SetActive(false);
#endif
    }
    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR

        if (Input.GetKey(KeyCode.LeftAlt))
        {
            //if (Input.GetMouseButtonDown(0))
            //{
            mousePos[1] = Input.mousePosition;
            //}

            if (Input.GetMouseButton(0) )
            {
                Vector3 deltaPos = mousePos[1] - mousePos[0];
                if (Mathf.Abs(deltaPos.y) > Mathf.Abs(deltaPos.x))
                {
                    transform.localEulerAngles = new Vector3(transform.localEulerAngles.x-deltaPos.y * Senstivity, transform.localEulerAngles.y, transform.localEulerAngles.z);
                }
                else if (Mathf.Abs(deltaPos.x) > Mathf.Abs(deltaPos.y))
                {
                    transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y+deltaPos.x * Senstivity, transform.localEulerAngles.z);
                }
            }

            else if (Input.GetMouseButtonDown(2))
            {
            transform.localEulerAngles = Vector3.zero;
            }
        }
#endif
    }
    private void LateUpdate()
    {
        mousePos[0] = mousePos[1];
    }
}
