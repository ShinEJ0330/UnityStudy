using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject cube;
    public string changeName;
    void Start()
    {
        cube = GameObject.Find("Main Camera");
        cube.name = changeName;
    }
}
