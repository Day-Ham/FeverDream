using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CinemachineFreeLook))]
public class CameraLook : MonoBehaviour
{
    private CinemachineFreeLook cinemachine;
    [SerializeField] float lookSpeed;
    [SerializeField] PlayerController controller;


    // Start is called before the first frame update
    void Start()
    {
        cinemachine = GetComponent<CinemachineFreeLook>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 delta = controller.Look();
        cinemachine.m_XAxis.Value += delta.x * lookSpeed * Time.deltaTime;
        cinemachine.m_YAxis.Value += delta.y * lookSpeed/1000 * Time.deltaTime;
    }
}
