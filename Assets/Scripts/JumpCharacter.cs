using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCharacter : MonoBehaviour
{
    [SerializeField] private Animator m_animator = null;
    [SerializeField] private Rigidbody m_rigidBody = null;
    public int jumpForce = 8;
    public int sec;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(sec);
        m_rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        m_animator.SetTrigger("Jump");
    }
}
