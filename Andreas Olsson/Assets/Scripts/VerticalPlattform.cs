using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlattform : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float speed;
    public float RestartTimer;
    private void MoveUp()
    {
        _rb.velocity = transform.up * speed;
    }

    private void MoveDown()
    {
        _rb.velocity = -transform.up * speed;
    }

    private void Start()
    {
        InvokeRepeating("MoveUp", 0, RestartTimer);
        InvokeRepeating("MoveDown", RestartTimer/2, RestartTimer);
    }


}
