using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSilver : MonoBehaviour
{
    public int diamond_value;
    public GameObject ScoreBox;
    public AudioSource GemCollected;

    private void OnTriggerEnter()
    {
        GlobalScore.currentScore += diamond_value;
        GemCollected.Play();
        Destroy(gameObject);
    }
}
