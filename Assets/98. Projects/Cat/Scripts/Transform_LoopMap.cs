using TreeEditor;
using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Vector3 returnPos = new Vector3(30f, 1.5f, 0f);
    
    void Update()
    {
        // 배경 왼쪽으로 이동하는 기능
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

        // 배경이 -30이 되는 순간 30으로 위치 초기화
        if (transform.position.x <= -30f)
        {
            transform.position = returnPos;
        } 
    }
}
