using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Tooltip("camera positions")] 
    [SerializeField] Transform[] povs;
    [Tooltip("camera following's speed")]
    [SerializeField] private float speed;

    private int index = 0;
    private Vector3 target;

    public Camera cam;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            index = 0;
            cam.fieldOfView = 60f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            index = 1;
            cam.fieldOfView = 40f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) index = 2;
        else if (Input.GetKeyDown(KeyCode.Alpha4)) index = 3;

        target = povs[index].position;
        
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        transform.forward = povs[index].forward;
    }

    private void FixedUpdate()
    {
        /*transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        transform.forward = povs[index].forward;*/
    }
}
