using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCharacter : MonoBehaviour
{
    public GameObject Character;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Character.transform.position = new Vector3(-6.487956f, 1.43803f, 14.43859f);
    }
}
