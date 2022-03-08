using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera startCamera;
    public Camera secondCamera;
    public List<Camera> cameras;

    private void Start()
    {
       // startCamera.enabled = true;
       // secondCamera.enabled = false;
        ActivateCamera(startCamera);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            startCamera.enabled = !startCamera.enabled;
            secondCamera.enabled = !secondCamera.enabled;
        }
    }

    public void ActivateCamera(Camera camera) //pressed the button to switch the camera
    {
        camera.enabled = true;
        foreach (Camera c in cameras)
        {
            c.enabled = false;
        }
        camera.enabled = true;
    }

}
