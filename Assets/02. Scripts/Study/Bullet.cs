using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;
    void Update()
    {
        transform.position += -transform.up * bulletSpeed * Time.deltaTime;
    }
}
