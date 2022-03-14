using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform destination;
    public GameObject blockHolder;
    private Rigidbody rb;
    private BoxCollider collider;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
    }

    public void PickUp() //als face beweegt, ook nog de raycast mee bewegen naar beneden
    {
        if (blockHolder.GetComponentInChildren<Pickup>() == null)
        {
            collider.enabled = false;
            rb.useGravity = false;
            this.transform.position = destination.position;
            this.transform.parent = blockHolder.transform;
        }
    }

    public void Drop()
    {
        if (blockHolder.GetComponentInChildren<Pickup>() != null)
        {
            this.transform.parent = null;
            rb.useGravity = true;
            collider.enabled = true;
        }
    }
}
