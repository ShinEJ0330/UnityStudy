using System;
using UnityEngine;
using Cat;
using UnityEditor;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager;
    private Rigidbody2D catRb;
    private Animator CatAnim;
    public float jumpPower = 30f;
    public float limitPower = 25f;
    public bool isGround = false;
    public int jumpCount = 0;
    public GameObject StartCanvas;
    public static bool isStarted = false;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        CatAnim = GetComponent<Animator>();

        StartCanvas.SetActive(true);
    }

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        // 점프
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 5)
        {
            isStarted = true;
            StartCanvas.SetActive(false);

            CatAnim.SetTrigger("Jump");
            CatAnim.SetBool("isGround", false);
            jumpCount++;
            soundManager.OnJumpSound();

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);

            if (catRb.linearVelocityY > limitPower)
                catRb.linearVelocityY = limitPower;
        }
        var catRotation = transform.eulerAngles;
        catRotation.z = catRb.linearVelocityY * 2.5f;
        transform.eulerAngles = catRotation;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            other.gameObject.SetActive(false);
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);

            GameManager.score++;
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
