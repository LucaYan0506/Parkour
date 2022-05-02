using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBegin : MonoBehaviour
{
    public GameObject fadeIn;

    // Start is called before the first frame update
    void Start()
    {
        GlobalScore.currentScore = 0;
        GlobalTimer.timer_s = 150;
        fadeIn.SetActive(true);
        StartCoroutine(animation());
    }

    IEnumerator animation()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
