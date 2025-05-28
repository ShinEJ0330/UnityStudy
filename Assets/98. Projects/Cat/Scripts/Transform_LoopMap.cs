using TreeEditor;
using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float returnPosX = 10f;
    public float randomPosY;
    public int a, b;
    
    void Update()
    {
        // 배경 왼쪽으로 이동하는 기능
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

        // 배경이 -30이 되는 순간 30으로 위치 초기화
        if (transform.position.x <= -returnPosX)
        {
            randomPosY = Random.Range(a, b);
            transform.position = new Vector3(returnPosX, randomPosY, 3);
        } 
    }
}
