using UnityEngine;

public class StudyCasting : MonoBehaviour
{
    int number1 = 1;
    float number2 = 10f;

    void Start()
    {
        number1 = (int)number2;
        Debug.Log(number1);

        float number3 = Mathf.Floor(number2);
        float number4 = Mathf.Ceil(number2);
        float number5 = Mathf.Round(number2);

        Debug.Log(number3);
        Debug.Log(number4);
        Debug.Log(number5);

        string str1 = "123";
        string str2 = "456";

        Debug.Log(str1 + str2);

        int num1 = int.Parse(str1);
        int num2 = int.Parse(str2);

        Debug.Log(num1 + num2);
    }
}