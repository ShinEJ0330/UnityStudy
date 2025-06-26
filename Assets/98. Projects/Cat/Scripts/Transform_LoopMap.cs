using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public enum ColliderType { Bird1, Bird2, Bird3 }
    public ColliderType colliderType;
    public GameObject bird1;
    public GameObject bird2;
    public GameObject bird3;
    public float moveSpeed = 3f;
    public float returnPosX = 10f;
    public float randomPosY;
    private Vector3 initPos;
    //public int a, b;
    void Start()
    {
        SetRandomSetting(transform.position.x);
        //randomPosY = Random.Range(a, b);
    }
    void Awake()
    {
        initPos = transform.localPosition;
    }
    
    void OnEnable()
    {
        SetRandomSetting(initPos.x);
    }
    void Update()
    {
        if (CatController.isStarted)
        {

            // 배경 왼쪽으로 이동하는 기능
            transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

            // 배경이 -30이 되는 순간 30으로 위치 초기화
            if (transform.position.x <= -returnPosX)
            {
                SetRandomSetting(returnPosX);
            }
        }
    }
    private void SetRandomSetting(float posX)
    {
        randomPosY = Random.Range(1, 5);
        transform.position = new Vector3(posX, randomPosY, 0);
        
        bird1.SetActive(false);
        bird2.SetActive(false);
        bird3.SetActive(false);

        colliderType = (ColliderType)Random.Range(0, 3);
        switch (colliderType)
        {
            case ColliderType.Bird1:
                bird1.SetActive(true);
                break;
            case ColliderType.Bird2:
                bird1.SetActive(true);
                bird2.SetActive(true);
                break;
            case ColliderType.Bird3:
                bird1.SetActive(true);
                bird2.SetActive(true);
                bird3.SetActive(true);
                break;
        }
    }
}
