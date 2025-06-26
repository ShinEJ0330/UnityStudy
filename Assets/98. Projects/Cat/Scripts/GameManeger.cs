using TMPro;
using UnityEngine;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI scoreUI;

        private float timer;
        public static int score;
        public static bool isPlay = false;

        void Update()
        {
            Debug.Log(isPlay);

            if (!isPlay) return;

            timer += Time.deltaTime;

            playTimeUI.text = $"Play Time : {timer:F0}";
            // playTimeUI.text = string.Format("플레이 시간 : {0:F1}초", timer);

            scoreUI.text = $"X {score}";
        }

        public void ScoreReset()
        {
            timer = 0f;
            score = 0;

            // UI 텍스트도 초기화
            playTimeUI.text = $"Play Time : {timer:F0}";
            scoreUI.text = $"X {score}";
        }
    }
}
