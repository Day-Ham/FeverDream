using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputMaster controls = null;

    private void Awake()
    {
        controls = new InputMaster();
        controls.Player.Movement.performed += context => Move();
    }
    public Vector2 Move()
    {
        
        return controls.Player.Movement.ReadValue<Vector2>();
    }













    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}
