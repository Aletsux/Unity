using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 1;
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private Animator _ar;
    private BoxCollider2D _bc;
    [SerializeField] private LayerMask _Plm;
    private float boostTimer;
    private bool boosting;
    public GameObject objectToFind;
    string tagName = "SpeedBoost";
    AudioSource _as;
    public AudioSource jumpSound;
    public AudioSource pickUpSound;

    // Start is called before the first frame update
    void Start()
    {
        objectToFind = GameObject.FindGameObjectWithTag(tagName);
        moveSpeed = 5f;
        boostTimer = 0;
        boosting = false;
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _ar = GetComponent<Animator>();
        _bc = GetComponent<BoxCollider2D>();
        _as = GetComponent<AudioSource>();
       
        
    }

    // Update is called once per frame

    void Update()
    {
        //Move
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;
        if(IsGrounded() && movement != 0)
        {
            if (!_as.isPlaying)
            {
                _as.Play();
            }
        }
        else
        {
            _as.Stop();
        }

        //SpeedBoost
        if (boosting)
        {
            boostTimer += Time.deltaTime;
            if (boostTimer >= 2)
            {
                moveSpeed = 5;
                boostTimer = 0;
                boosting = false;
            }
        }

        //Flip
        if (Input.GetAxisRaw("Horizontal") > 0)
            _sr.flipX = false;
        else if (Input.GetAxisRaw("Horizontal") < 0)
            _sr.flipX = true;

        // Walk animation
        if (movement != 0) _ar.SetBool("Run", true);
        else _ar.SetBool("Run", false);

        //Jump
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            jumpSound.Play();
            _ar.SetTrigger("Takeoff");
            _rb.velocity = Vector2.up * jumpForce;
        }
        if (IsGrounded())
        {
            _ar.SetBool("IsJumping", false);
        }
        else
        {
            _ar.SetBool("IsJumping", true);
        }
            
                
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("SpeedBoost") == true)
        {
            pickUpSound.Play();
            boosting = true;
            moveSpeed = 7;
            Destroy(objectToFind);
        }
    }
    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(_bc.bounds.center, _bc.bounds.size, 0f, Vector2.down, .1f, _Plm);
        return raycastHit2d.collider != null;
    }
           

}