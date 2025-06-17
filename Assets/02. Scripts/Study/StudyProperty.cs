using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class StudyProperty : MonoBehaviour
{
    //public int Number1 { get; } = 20; // 읽기 전용
    //public int Number2 { get; private set; } = 30; // private get 내부에서만 접근 가능, set 내부에서만 수정 가능
    [Header ("속도")]
    [SerializeField] private float moveSpeed;
    [Space (10)] // 띄어쓰기
    [Header ("속도2")]
    [SerializeField] private float moveSpeed2;
    void Start()
    {
        
    }
}