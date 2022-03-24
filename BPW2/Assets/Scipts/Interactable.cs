using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Material btnRed;
    public Material btnGreen;
    Renderer rend;
    public Canvas canvas;
    public GameObject player;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = btnRed;
        canvas.enabled = false;
    }

    public void activateCoroutine()
    {
        StartCoroutine(setMaterial());
        if(this.CompareTag("Screen"))
        {
            canvas.enabled = true;
            player.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void backToCamera()
    {
        canvas.enabled = false;
        player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public IEnumerator setMaterial()
    {
        rend.sharedMaterial = btnGreen;
        yield return new WaitForSeconds(0.5f);
        rend.sharedMaterial = btnRed;
    }
}
