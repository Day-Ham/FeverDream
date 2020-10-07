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
        controls.Player.Look.performed += context => Look();
    }
    public Vector2 Move()
    {
        return controls.Player.Movement.ReadValue<Vector2>();
    }

    public Vector2 Look()
    {
        return controls.Player.Look.ReadValue<Vector2>();
    }

    public void OnEnable()
    {
        controls.Enable();
    }
    public void OnDisable()
    {
        controls.Disable();
    }
}
