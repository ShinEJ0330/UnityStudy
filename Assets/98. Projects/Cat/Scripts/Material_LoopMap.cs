using UnityEngine;

public class Material_LoopMap : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float offsetSpeed = 0.1f;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = Vector2.right * offsetSpeed * Time.deltaTime;
        meshRenderer.material.SetTextureOffset("_MainTex", meshRenderer.material.mainTextureOffset + offset);
    }
}
