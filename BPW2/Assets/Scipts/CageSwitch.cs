using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageSwitch : MonoBehaviour
{
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
        if (other.CompareTag("PickupBlock"))
        {
            rend.sharedMaterial = btnGreen;
            if (transform.GetChild(0) != null)
            {
                Destroy(transform.GetChild(0).gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PickupBlock"))
        {
            rend.sharedMaterial = btnStart;
        }
    }
}
