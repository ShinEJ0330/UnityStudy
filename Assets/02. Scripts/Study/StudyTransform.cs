using TreeEditor;
using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotSpeed = 70f;
    void Update()
    {
        // 월드 방향으로 이동하는 기능
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        //로컬 방향으로 이동하는 기능
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 월드 방향으로 회전
        //transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime, Space.World);

        // 로컬 방향으로 회전
        //transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime); 

        // 특정 위치 주변을 회전 y 기준으로
        // transform.RotateAround(Vector3.zero, Vector3.up, rotSpeed * Time.deltaTime);

        // 특정 위치를 바라보는 기능? > 해당 위치 or 물체를 바라보기
        transform.LookAt(Vector3.zero);
    }
}
