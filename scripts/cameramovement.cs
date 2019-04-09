using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{

    public float speed;

    public bool moveForward;

    public float toggleAngleFUp;

    public float toggleAngleFDn;

    public Transform vrCamera;

    // Use this for initialization
    void Start()
    {
        Debug.Log("hello");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vrCamera.eulerAngles.x);
        if (vrCamera.eulerAngles.x >= toggleAngleFDn && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
            Debug.Log(vrCamera.eulerAngles.x);

        }
        else if (vrCamera.eulerAngles.x >= 270.0f && vrCamera.eulerAngles.x <= toggleAngleFUp)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
            Debug.Log("hello");
        }


        if (moveForward)
        {
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
    }
}
