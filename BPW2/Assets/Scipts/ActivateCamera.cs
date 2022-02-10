using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCamera : MonoBehaviour
{
    public bool isActive;
    public SwitchCamera cameraController;

    private void Start()
    {
        isActive = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            isActive = true;
        }
        AddCamera();
    }

    private void AddCamera()
    {
        if(isActive)
        {
            cameraController.AddCameras(Component.FindObjectOfType<Camera>());
        }
    }
}
