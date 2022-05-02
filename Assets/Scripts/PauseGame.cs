using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool game_paused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!game_paused)
            {
                Time.timeScale = 0;
                game_paused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                Cursor.visible = false;
                game_paused = false;
                Time.timeScale = 1;
                levelMusic.UnPause();
                pauseMenu.SetActive(false);
            }
        }   
    }

    public void ResumeGame()
    {
        Cursor.visible = false;
        PauseGame.game_paused = false;
        Time.timeScale = 1;
        levelMusic.UnPause();
        pauseMenu.SetActive(false);
    }
    public void SelectLevel()
    {
        Cursor.visible = false;
        PauseGame.game_paused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void RestartLevel()
    {
        Cursor.visible = false;
        PauseGame.game_paused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
    public void QuitToMenu()
    {
        Cursor.visible = true;
        PauseGame.game_paused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

}
