using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScrollCredits : MonoBehaviour
{
    public GameObject credit;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RollCredits());
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator RollCredits()
    {
        yield return new WaitForSeconds(1);
        credit.SetActive(true); 
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(0); 
    }
}
