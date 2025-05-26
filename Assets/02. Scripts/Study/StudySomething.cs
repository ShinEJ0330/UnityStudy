using UnityEngine;

public class StudySomething : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;

    void Start()
    {
        bool isMax = currentLevel >= maxLevel;
        string msg = isMax ? "만렙" : "만렙아님";
        Debug.Log(msg);
        //Debug.Log($"현재 레벨은 만렙이 {isMax}입니다.");
    }
}
