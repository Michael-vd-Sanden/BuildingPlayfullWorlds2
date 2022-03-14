using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Interactable focus;
    public SwitchCamera switchCamera;
    public Pickup pickupBlock;
    public GameObject face;

    private float maxHeightFace = 1.4f;
    private float minHeightFace = 0.4f;

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

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 5f))
            {
                Pickup block = hit.collider.GetComponent<Pickup>();
                if (block != null)
                {
                    block.PickUp();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            pickupBlock.Drop();
        }


        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            moveFaceDown();
        }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            moveFaceUp();
        }
    }

    void moveFaceDown()
    {
        Vector3 pos = face.transform.position;
        if (pos.y > minHeightFace && pos.y < maxHeightFace) //ranges werken nog niet, apart werkt t wel
        {
            pos.y -= 0.1f;
            face.transform.position = pos;
        }

    }
    void moveFaceUp()
    {
        Vector3 pos = face.transform.position;
        if (pos.y > minHeightFace && pos.y < maxHeightFace)
        {
            pos.y += 0.1f;
            face.transform.position = pos;
        }
    }

    void SetFocus (Interactable newFocus)
    {
        focus = newFocus;
    }
}
