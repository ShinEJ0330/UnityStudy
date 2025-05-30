using UnityEngine;

public class CoinObject : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Movement.coinCount++;
            
            Debug.Log($"{Movement.coinCount}개 코인 획득!!!");

            Destroy(gameObject);
        }
    }
}
