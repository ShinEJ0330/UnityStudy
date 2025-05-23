using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;

    void Awake()
    {
        //Debug.Log("생성되었습니다.");
        CreateAmongus();

        //Destroy(destroyObj, 3f); //파괴하는 기능
    }
    /*
    void OnDestroy()
    {
        Debug.Log("파괴되었습니다.");
    }
    */

    //어몽어스 캐릭터 생성 후 이름 변경하는 기능
    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "캐릭터";

        int objCount = obj.transform.childCount;
        
        //Debug.Log("캐릭터의 자식 오브젝트의 수 " + objCount);
        //Debug.Log("캐릭터의 첫번째 자식 오브젝트의 수 " + obj.transform.GetChild(0).name);
        //Debug.Log("캐릭터의 마지막 자식 오브젝트의 수 " + obj.transform.GetChild(objCount - 1).name);
    }
}
