using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportCharacter : MonoBehaviour
{
    public GameObject Character;
    public GameObject teleporting;
    public Vector3 pos;

    private bool inside;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        inside = true;
        teleporting.SetActive(true);
        StartCoroutine(delay(2));
    }

    private void OnTriggerExit(Collider other)
    {
        inside = false;
        teleporting.SetActive(false);
    }
    IEnumerator delay(int second)
    {
        yield return new WaitForSeconds(second);
        if (inside)
        {
            Character.transform.position = pos;
            teleporting.SetActive(false);
        }

    }
}
