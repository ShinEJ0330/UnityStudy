using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotSpeed = 30f;
    public float revolutionSpeed = 30f;

    public bool isRevolution = false;

    void Update()
    {
        // 자전
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        
        // 공전
        if (isRevolution == true)
        {
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
    }
}
