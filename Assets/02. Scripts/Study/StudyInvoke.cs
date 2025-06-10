using UnityEngine;

public class StudyInvoke : MonoBehaviour
{
    public float timer = 5f;

    void Start()
    {
        //Invoke("Method", timer);

        //CancelInvoke("Method");

        InvokeRepeating("Method", 3f, 1f); // 함수명, 지연시간, 몇초마다 실행
    }

    private void Method()
    {
        Debug.Log("Method 실행");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("Method");
        }
    }
}
