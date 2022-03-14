using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject blockHolder;
    private Rigidbody rb;
    private BoxCollider collider;
    private bool inRange;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
        inRange = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(inRange)
            {
                PickUp();
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Drop();
        }
    }

    public void PickUp() 
    {
        if (blockHolder.GetComponentInChildren<Pickup>() == null)
        {          
            this.transform.position = blockHolder.transform.position;
            this.transform.parent = blockHolder.transform;
            rb.useGravity = false;
            collider.enabled = false; 
        }
    }

    public void Drop()
    {
        if (blockHolder.GetComponentInChildren<Pickup>() != null)
        {
            this.transform.parent = null;
            collider.enabled = true;
            rb.useGravity = true;     
        }
    }
}
