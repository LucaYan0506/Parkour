using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject TimeDisplay1;
    public GameObject TimeDisplay2;
    public bool start = true;
    public static int timer_s = 150;

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            StartCoroutine(SubstractSecond());
        }
    }

    IEnumerator SubstractSecond()
    {
        start = false;
        timer_s--;
        TimeDisplay1.GetComponent<Text>().text = timer_s.ToString();
        TimeDisplay2.GetComponent<Text>().text = timer_s.ToString();
        yield return new WaitForSeconds(1);
        start = true;
    }   
}
