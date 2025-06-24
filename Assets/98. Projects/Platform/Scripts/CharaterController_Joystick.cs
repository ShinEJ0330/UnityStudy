using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class CharaterController_Joystick : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D CharRb;

    [SerializeField] private Button jumpButton;
    [SerializeField] private Button attackButton;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 10f;
    private bool isGround = false;
    private bool isAttack = false;
    private bool isCombo = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        CharRb = GetComponent<Rigidbody2D>();

        jumpButton.onClick.AddListener(Jump);
        attackButton.onClick.AddListener(Attack);
    }
    void Update()
    {

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
    public void InputJoystick(float x, float y)
    {
        inputDir = new Vector3(x, y, 0).normalized;

        animator.SetFloat("JoystickX", inputDir.x);
        animator.SetFloat("JoystickY", inputDir.y);

        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
        }
    }
    void Move()
    {
        if (inputDir.x != 0)
            CharRb.linearVelocityX = inputDir.x * moveSpeed;
    }
    void Jump()
    {
        if (isGround)
        {
            animator.SetTrigger("Jump");
            CharRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
    void Attack()
    {
        if (!isAttack)
        {
            isAttack = true;
            animator.SetTrigger("Attack");
        }
        else
        {
            isCombo = true;
        }
    }
    public void CheckCombo()
    {
        if (isCombo)
        {
            animator.SetBool("isCombo", true);
        }
        else
        {
            animator.SetBool("isCombo", false);
            isAttack = false;
        }
    }
}
