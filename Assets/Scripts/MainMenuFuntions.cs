using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFuntions : MonoBehaviour
{
    public AudioSource buttonPress;
    public void PlayGame()
    {
        buttonPress.Play();
        //load redirectToLevel scene
        SceneManager.LoadScene(1);
    }

    public void QuiteGame()
    {
        Application.Quit();
    }

    public void showCredit()
    {
        SceneManager.LoadScene(2);
    }
}
