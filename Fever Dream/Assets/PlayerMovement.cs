using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerController controller;
    [SerializeField] Rigidbody rb;
    [SerializeField] float turnSmoothTime = 0.1f;
                     float smoothVelocity;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] Vector2 movementInput;
    Camera cam;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 camForward = cam.transform.forward;
        Vector3 camRight = cam.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        Vector3 direction = (camForward* controller.Move().y)+ (camRight * controller.Move().x);
        if(direction.magnitude >= 0.1f || direction.magnitude <= -0.1f)
        {
         Move(direction);
         Turn(direction);
        }
    }

    private void Turn(Vector3 direction)
    {
        float targetAngle = Mathf.Atan2(direction.x, direction.z)* Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }

    void Move(Vector3 dir)
    {
        rb.velocity = dir * moveSpeed * Time.deltaTime;
    }
}
