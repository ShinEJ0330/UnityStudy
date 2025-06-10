using UnityEngine;

public class StudyForeach : MonoBehaviour
{
    public string[] persons = new string[5] { "은지", "연지", "예진", "미희", "혜원" };
    public string findName;
    void Start()
    {
        /*foreach (string person in persons)
        {
            Debug.Log(person);
        }*/
        FindPerson(findName);
    }

    private void FindPerson(string neme)
    {
        bool isFind = false;
        foreach (var person in persons)
        {
            if (person == name)
            {
                Debug.Log(name);
                isFind = true;
            }
        }
        
        if (!isFind)
            Debug.Log("없음...");
    }
}
