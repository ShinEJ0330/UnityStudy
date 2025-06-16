using UnityEngine;

public class Character : MonoBehaviour
{
    public float hp;
    public float moveSpeed;

    public virtual void Attack()
    {
        Debug.Log("공격");
    }

    public virtual void Move()
    {
        Debug.Log("이동");
    }
}
