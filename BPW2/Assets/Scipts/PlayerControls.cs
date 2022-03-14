using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Interactable focus;
    public SwitchCamera switchCamera;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null) // hit 
                {
                    //press button
                    SetFocus(interactable);
                    Debug.Log("Pressed button");
                    focus.activateCoroutine();
                    switchCamera.ActivateCamera(focus.GetComponentInParent<Camera>());
                }
            }
        }
    }

    void SetFocus (Interactable newFocus)
    {
        focus = newFocus;
    }
}
