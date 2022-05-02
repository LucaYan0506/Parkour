using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int redirectToLevel;
    bool start = true;

    // Update is called once per frame
    void Update()
    {
        if (start)
            StartCoroutine(redirect());
    }


    IEnumerator redirect()
    {
        start = false;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(redirectToLevel);
        start = true;
    }
}
