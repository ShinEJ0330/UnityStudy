using System;
using UnityEngine;
using Cat;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager;
    private Rigidbody2D catRb;
    private Animator CatAnim;
    public float jumpPower = 10f;
    public bool isGround = false;
    public int jumpCount = 0;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        CatAnim = GetComponent<Animator>();
    }

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        // 점프
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            CatAnim.SetTrigger("Jump");
            CatAnim.SetBool("isGround", false);

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;

            soundManager.OnJumpSound();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            CatAnim.SetBool("isGround", true);

            jumpCount = 0;
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
