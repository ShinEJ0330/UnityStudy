using UnityEngine;

public class Study_CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D carRb;
    private float h;
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        //transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;
    }

    void FixedUpdate() // Rigidbody를 이용한 무언가는 이 함수 이용
    {
        //물리적인 이동
        carRb.linearVelocityX = h * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("충돌!!!!!");
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("스테이이");
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("해방!!!");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌!!!!!");
    }
    void OnOnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("스테이이");
    }
    void OnOnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("해방!!!");
    }
}
