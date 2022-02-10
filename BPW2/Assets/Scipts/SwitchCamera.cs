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
        startCamera.enabled = true;
        secondCamera.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            startCamera.enabled = !startCamera.enabled;
            secondCamera.enabled = !secondCamera.enabled;
        }
    }

    public void AddCameras(Camera newCamara)
    {
        cameras.Add(newCamara);
    }
}
