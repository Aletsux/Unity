using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public float speed = 1f;
    private float moveDirection = 1f;
    Rigidbody2D _rb;
    bool IsGrounded;
    public GameObject groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPosition = gameObject.transform.position;
        newPosition.x += speed * Time.fixedDeltaTime * moveDirection;
        _rb.MovePosition(newPosition);

        CheckForGround();

        if (IsGrounded == false)
        {
            ChangeDirection();
        }
    }

    private void CheckForGround()
    {
        IsGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.transform.position, 0.2f);

        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                IsGrounded = true;
            }
        }
    }

    private void ChangeDirection()
    {
        moveDirection = -moveDirection;
        Vector3 newScale = gameObject.transform.localScale;
        newScale.x = moveDirection;
        gameObject.transform.localScale = newScale;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            ChangeDirection();
        }
    }
}










