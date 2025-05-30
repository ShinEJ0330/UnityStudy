using UnityEngine;

public class DoorEvent2 : MonoBehaviour
{
    private Animator animator;
    public string Openkey;
    public string Closekey;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger(Openkey);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger(Closekey);
        }
    }
}
