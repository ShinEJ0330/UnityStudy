using UnityEngine;
using System.Collections;

public class ColliderEvent : MonoBehaviour
{
    public GameObject fadeUI;
    public GameObject gameOver;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fadeUI.SetActive(true);
            StartCoroutine(ActivateAfterDelay(1.8f));
        }
    }
    IEnumerator ActivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // 대기
        gameOver.SetActive(true); // 오브젝트 켜기
    }
}