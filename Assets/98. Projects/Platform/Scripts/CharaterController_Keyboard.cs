using UnityEngine;

public class CharaterController_Keyboard : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D CharRb;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 10f;
    private bool isGround = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        CharRb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        InputKeyboard();
    }

    void FixedUpdate()
    {
        Move();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", false);
            isGround = false;
        }
    }
    void InputKeyboard()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        inputDir = new Vector3(h, v, 0);

        Jump();
        SetAnimation();
    }

    void Move()
    {
        if (inputDir.x != 0)
            CharRb.linearVelocityX = inputDir.x * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            animator.SetTrigger("Jump");
            CharRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }

    void SetAnimation()
    {
        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);

            animator.SetBool("isRun", true);
        }
        else if (inputDir.x == 0)
            animator.SetBool("isRun", false);
    }
}
