using System.Collections;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    public SpawnManager spawner;

    private SpriteRenderer sRenderer;
    private Animator animator;

    protected float hp = 30f;
    protected float moveSpeed = 3f;

    public int dir = 1;
    private bool isMove = true;
    private bool isHit = false;

    public abstract void Init();
    void Start()
    {
        spawner = FindFirstObjectByType<SpawnManager>();
        
        sRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        Init();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (!isMove) return;

        transform.position += Vector3.right * dir * moveSpeed * Time.deltaTime;

        if (transform.position.x > 8f)
        {
            dir = -1;
            sRenderer.flipX = true;
        }
        else if (transform.position.x < -8f)
        {
            dir = 1;
            sRenderer.flipX = false;
        }
        
    }

    void OnMouseDown()
    {
        StartCoroutine(Hit(1));
    }

    IEnumerator Hit(float damage)
    {
        if (isHit) yield break;
        
        isHit = true;
        isMove = false;

        hp -= damage;

        if (hp <= 0)
        {
            animator.SetTrigger("Death");
            Debug.Log("die");

            isHit = true;
            isMove = false;

            spawner.DropCoin(transform.position);

            yield return new WaitForSeconds(3f);
            Destroy(gameObject);

            yield break;
        }

        animator.SetTrigger("Hit");

        yield return new WaitForSeconds(0.5f);
        isHit = false;
        isMove = true;
    }
}