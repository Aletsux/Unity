using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private Animator _ar;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _ar = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
            
    }

    private void Die()
    {
        //_rb.bodyType = RigidbodyType2D.Static; funkar inte
        //_rb.constraints = RigidbodyConstraints2D.FreezeAll; funkar inte
        _ar.SetTrigger("Death");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
        
}