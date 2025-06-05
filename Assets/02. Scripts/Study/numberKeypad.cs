using System.ComponentModel;
using UnityEngine;

public class numberKeypad : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject doorlock;
    public string password;
    public string keypadNumber;

    public void OnInputNumber(string numString)
    {
        keypadNumber += numString;
        Debug.Log($"{numString} 입력 > 현재 입력 {keypadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keypadNumber == password)
        {
            Debug.Log("문 열림");

            doorAnim.SetTrigger("Door Open");
            doorlock.SetActive(false);
        }
        else
        {
            keypadNumber = "";
            Debug.Log("? 삐빅");
        }
    }
}
