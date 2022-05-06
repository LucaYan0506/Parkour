using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attracted : MonoBehaviour
{
    public GameObject attractTo;

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(attractTo.transform.position, transform.position);
        if (dis < 10)
        {
            float speed = 10 - dis;
            speed = speed * Time.deltaTime * 0.2f;
            transform.position = Vector3.MoveTowards(transform.position, attractTo.transform.position, speed);
        }

    }
}
