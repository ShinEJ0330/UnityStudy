using UnityEngine; //unityEngine이라는 네임스페이스를 활용하겠다.
using System.Collections.Generic;

public class StudyComponent : MonoBehaviour
{
    //public GameObject cube;
    //public string changeName;

    public GameObject obj;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        //cube = GameObject.Find("Main Camera"); // 메인 카메라 오브젝트를 찾아서 할당하는 기능
        //cube.name = changeName;

        //cube = GameObject.FindGameObjectWithTag("New tag"); // Tag를 이용해서 찾는 기능

        //Debug.Log(cube.name);
        //Debug.Log(cube.tag);
        //Debug.Log("위치" + cube.transform.position);
        //Debug.Log(cube.transform.rotation);
        //Debug.Log(cube.transform.localScale);

        //Debug.Log("Mesh 데이터" + cube.GetComponent<MeshFilter>().mesh);
        //Debug.Log("Meterial 데이터" + cube.GetComponent<MeshRenderer>().material);

        // ------------------------------------------------------------------------------
        //cube.GetComponent<MeshRenderer>().enabled = false;
        //cube.SetActive(false);
        // ------------------------------------------------------------------------------

        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        CreateCube();
        CreateCube("Hello World");
    }

    public void CreateCube(string name = "Cube")
    {
        // 코드로 큐브 만들기

        obj = new GameObject("CubeObj");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
