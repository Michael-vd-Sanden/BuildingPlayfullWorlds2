using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerCamera : MonoBehaviour
{
    public SwitchCamera switchCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switchCamera.ActivateCamera(GetComponentInParent<Camera>());
        }
    }
}
