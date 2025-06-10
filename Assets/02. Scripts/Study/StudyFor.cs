using System.Collections.Generic;
using UnityEngine;

public class StudyFor : MonoBehaviour
{
    //public int[] arrayInt = new int[5];
    public List<int> listInt = new List<int>();
    void Start()
    {
        for (int i = 0; i < listInt.Count; i++)
        {
            Debug.Log(listInt[i]);
        }
    }
}
