using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameFinishTrigger : MonoBehaviour
{
    public AudioSource music;
    public GameObject timer;
    public GameObject canvasText;
    public GameObject Fadeout;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(levelComplete());
    }

    IEnumerator levelComplete()
    {
        music.Play();
        timer.SetActive(false);
        canvasText.SetActive(true);
        Text[] all_text = canvasText.GetComponentsInChildren<Text>();
        foreach (Text x in all_text)
        {
            if (x.name == "ScoreTxt")
            {
                x.text = "Time Left: " + GlobalTimer.timer_s.ToString() + " x 100" + "\n";
                x.text += "Score: " + GlobalScore.currentScore.ToString() + "\n";
                x.text += "Total Score: " + (GlobalTimer.timer_s * 100 + GlobalScore.currentScore).ToString();
            }
        }

        int n_star = 0;
        if (GlobalTimer.timer_s * 100 + GlobalScore.currentScore >= 13600)
        {
            n_star++;

            int highestLevel = PlayerPrefs.GetInt("highestLevel", 0);
            int currentLevel = int.Parse(SceneManager.GetActiveScene().name.Substring(5));
            PlayerPrefs.SetInt("highestLevel", Mathf.Max(highestLevel, currentLevel + 1));

            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, 1);
        }
        if (GlobalTimer.timer_s * 100 + GlobalScore.currentScore >= 15600)
            n_star++;
        if (GlobalTimer.timer_s * 100 + GlobalScore.currentScore >= 17600)
            n_star++;

        PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_n_star", n_star);

        yield return new WaitForSeconds(3);

        Fadeout.SetActive(true);
        
        yield return new WaitForSeconds(1);

        RedirectToLevel.redirectToLevel = 1;
        SceneManager.LoadScene(3);
    }
}
