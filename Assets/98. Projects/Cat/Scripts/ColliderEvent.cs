using UnityEngine;
using System.Collections;
using Cat;

public class ColliderEvent : MonoBehaviour
{
    public VideoManager videoManager;
    public GameObject fadeUI;
    public GameObject rankingPanel;
    public GameObject itemObjects;
    public GameObject cat;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fadeUI.SetActive(true);
            GameManager.isPlay = false;
            StartCoroutine(ActivateAfterDelay(1.8f));

            rankingPanel.SetActive(true);
            itemObjects.SetActive(false);
            cat.SetActive(false);

            videoManager.VideoPlay(GameManager.score >= 3);;
        }
    }
    IEnumerator ActivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // 대기
    }
}