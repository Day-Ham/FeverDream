using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerController controller;
    [SerializeField] Rigidbody rb;
    [SerializeField] float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 moveDirection = transform.right * controller.Move().x + transform.forward * controller.Move().y;
        rb.velocity = moveDirection * moveSpeed;
    }
}
