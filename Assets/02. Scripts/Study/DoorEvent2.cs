using UnityEngine;

public class DoorEvent2 : MonoBehaviour
{
    private Animator animator;

    public GameObject doorlock;

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
            //animator.SetTrigger(Openkey);
            doorlock.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //animator.SetTrigger(Closekey);
            doorlock.SetActive(false);
        }
    }
}
