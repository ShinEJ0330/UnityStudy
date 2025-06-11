using UnityEngine;
using System.Collections;
using Cat;

public class ColliderEvent : MonoBehaviour
{
    public GameObject fadeUI;
    public GameObject gameOver;
    public GameObject rankingPanel;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fadeUI.SetActive(true);
            GameManager.isPlay = false;
            StartCoroutine(ActivateAfterDelay(1.8f));

            rankingPanel.SetActive(true);
        }
    }
    IEnumerator ActivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // 대기
        gameOver.SetActive(true); // 오브젝트 켜기
    }
}