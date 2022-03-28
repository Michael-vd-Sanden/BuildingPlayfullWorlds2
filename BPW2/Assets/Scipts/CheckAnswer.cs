using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    public InputField circle;
    public InputField star;
    public InputField triangle;

    public GameObject endDoor;
    public Canvas canvas;
    public GameObject player;

    public void CheckIfCorrect()
    {
        if (circle.text == "3" && star.text == "5" && triangle.text == "4")
        {
            Debug.Log("Correct");
            canvas.enabled = false;
            player.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            endDoor.SetActive(false);
        }
    }
}
