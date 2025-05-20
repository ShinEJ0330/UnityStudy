using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1;
    public int number2;

    void Start()
    {
        int addReturn = AddMethod();
        int minusReturn = MinusMethod();

        Debug.Log("더하기 : " + addReturn + " / 빼기 : " + minusReturn);
    }

    int AddMethod()
    {
        int result = number1 + number2;
        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;
        return result;
    }
}
