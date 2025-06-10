using UnityEditor.Analytics;
using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType {Pipe, Fruit, Both}
    public ColliderType colliderType;

    public GameObject pipe;
    public GameObject fruit;

    public GameObject particle; // 터지는 이미지

    public float moveSpeed = 3f;
    public float returnPosX = 10f;
    public float randomPosY;
    void Start()
    {
        SetRandomSetting(transform.position.x);
    }
    void Update()
    {
        if (CatController.isStarted)
        {

            // 배경 왼쪽으로 이동하는 기능
            transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

            // 배경이 -30이 되는 순간 30으로 위치 초기화
            if (transform.position.x <= -returnPosX)
                SetRandomSetting(returnPosX);
        }
    }

    private void SetRandomSetting(float posX)
    {
        randomPosY = Random.Range(-8, -3);
        transform.position = new Vector3(posX, randomPosY, 3);
        pipe.SetActive(false);
        fruit.SetActive(false);
        particle.SetActive(false);

        colliderType = (ColliderType)Random.Range(0, 3);
        switch (colliderType)
        {
            case ColliderType.Pipe:
                pipe.SetActive(true);
                break;
            case ColliderType.Fruit:
                fruit.SetActive(true);
                break;
            case ColliderType.Both:
                pipe.SetActive(true);
                fruit.SetActive(true);
                break;
        }
    }
}
