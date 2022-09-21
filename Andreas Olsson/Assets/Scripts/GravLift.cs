using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravLift : MonoBehaviour
{
	[SerializeField] Animator animator;

	[SerializeField] float jumpForce = 5f;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.transform.CompareTag("Player"))
		{
			collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * jumpForce);
		}
	}
}
