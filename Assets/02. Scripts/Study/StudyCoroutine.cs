using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class StudyCoroutine : MonoBehaviour
{
    private bool isStop = false;
    void Start()
    {
        //StartCoroutine("RoutineA");
        StartCoroutine(BombRoutine()); // 이게 더 나음
    }

    IEnumerator RoutineA() // 대기할 수 있는 기능
    {
        //yield return null;
        yield return new WaitForSeconds(2f);
        Debug.Log("코루틴 실행");

        yield return new WaitForSeconds(2f);
        Debug.Log("2초 대기");

        yield return new WaitForSeconds(2f);
        Debug.Log("코루틴 끝");
    }

    void StopMethod()
    {
        StopCoroutine("RoutineA");
        //StopCoroutine(RoutineA());
    }

    IEnumerator BombRoutine()
    {
        int t = 10;
        while (t > 0)
        {
            Debug.Log($"{t}초 남았습니다.");
            yield return new WaitForSeconds(1f);
            t--;

            if (isStop)
            {
                Debug.Log("폭탄이 해제되었습니다.");
                yield break;
            }
        }
        Debug.Log("펑!");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
    }
}
