using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerCamera : MonoBehaviour
{
    public SwitchCamera switchCamera;
    public Material btnGreen;
    public Material btnStart;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = btnStart;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switchCamera.ActivateCamera(GetComponentInParent<Camera>());
            rend.sharedMaterial = btnGreen;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rend.sharedMaterial = btnStart;
        }
    }
}
