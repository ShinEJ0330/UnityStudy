using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0f;
    public bool isStop = false;

    void Start()
    {
        rotSpeed = 0f;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed); // Vector3 = Z축
                                                      // transform.Rotate(0f, 0f, rotSpeed); > 이것도 가능 Z축으로 돌림

        // 마우스 왼쪽 > 회전
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 50f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if (isStop)
        {
            rotSpeed *= 0.95f;

            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }
    }
}
