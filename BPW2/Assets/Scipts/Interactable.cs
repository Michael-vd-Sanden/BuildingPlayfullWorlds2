using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Material btnRed;
    public Material btnGreen;
    Renderer rend;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = btnRed;
    }

    public void activateCoroutine()
    {
        StartCoroutine(setMaterial());
    }

    public IEnumerator setMaterial()
    {
        rend.sharedMaterial = btnGreen;
        yield return new WaitForSeconds(0.5f);
        rend.sharedMaterial = btnRed;
    }
}
