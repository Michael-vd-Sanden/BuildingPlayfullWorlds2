using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenButtons : MonoBehaviour
{
    public GameObject controls;
    public GameObject buttons;

    public void startGame()
    {
        SceneManager.LoadScene(sceneName: "MainScene");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("I quit");
    }

    public void seeControls()
    {
        controls.SetActive(true);
        buttons.SetActive(false);
    }

    public void hideControls()
    {
        controls.SetActive(false);
        buttons.SetActive(true);
    }
}
