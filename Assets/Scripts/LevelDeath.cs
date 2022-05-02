using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject canvas_youfell;
    public GameObject background_music;
    public GameObject fadeout;
    private void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
    }

    IEnumerator YouFellOff()
    {
        canvas_youfell.SetActive(true);
        background_music.SetActive(false);
        yield return new WaitForSeconds(1);
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);

    }
}
