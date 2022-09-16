using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlattform : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float speed;
    public float RestartTimer;
    private void MoveRight()
    {
        _rb.velocity = transform.right * speed;
    }

    private void MoveLeft()
    {
        _rb.velocity = -transform.right * speed;
    }

    private void Start()
    {
        InvokeRepeating("MoveRight", 0, RestartTimer);
        InvokeRepeating("MoveLeft", RestartTimer / 2, RestartTimer);
    }

}
