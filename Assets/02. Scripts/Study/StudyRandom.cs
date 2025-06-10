using UnityEngine;

public class StudyRandom : MonoBehaviour
{
    void OnEnable()
    {
        int ranNumber = Random.Range(1, 46);

        Debug.Log(ranNumber);
    }
}
