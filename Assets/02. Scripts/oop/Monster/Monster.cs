using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    private SpriteRenderer sRenderer;
    protected float hp = 30f;
    protected float moveSpeed = 3f;

    public int dir = 1;

    public abstract void Init();
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        Init();
    }

    void Update()
    {
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
        Hit(1);
    }

    void Hit(float damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Debug.Log("die");
            Destroy(gameObject);
        }
    }
}