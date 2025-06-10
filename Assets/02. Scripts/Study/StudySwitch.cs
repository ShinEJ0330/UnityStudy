using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    public enum CalculationType { Plus, Minus, Multiply, Divide }
    public CalculationType calculationType = CalculationType.Plus;

    public int input1, input2, result;

    void Start()
    {
        Debug.Log(Calculation());
    }

    private int Calculation()
    {
        switch (calculationType)
        {
            case CalculationType.Plus:
                result = input1 + input2;
                break;
            case CalculationType.Minus:
                result = input1 - input2;
                break;
            case CalculationType.Multiply:
                result = input1 * input2;
                break;
            case CalculationType.Divide:
                result = input1 / input2;
                break;
        }

        return result;
    }
}
