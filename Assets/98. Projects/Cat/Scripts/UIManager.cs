using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public GameManager gameManager;
        public TMP_InputField inputField;
        public TextMeshProUGUI[] nameTextsUI;
        public TextMeshProUGUI[] scoreTextsUI;
        public GameObject namePanel;
        public GameObject fadeUI;
        public GameObject itemObjects;
        public GameObject cat;
        private static bool isRank;

        private List<PlayerScore> playerScores = new List<PlayerScore>();

        public void OnRankButton()
        {
            if (isRank) return;

            string playerName = inputField.text;

            if (string.IsNullOrWhiteSpace(playerName))
            {
                Debug.Log("입력한 것이 없음");
                return;
            }

            // 점수 저장
            playerScores.Add(new PlayerScore(playerName, GameManager.score));
            isRank = true;

            // 높은 점수 순으로 정렬
            var top10 = playerScores.OrderByDescending(ps => ps.score).Take(10).ToList();

            // 상위 10개만 추리기
            for (int i = 0; i < 10; i++)
            {
                if (i < top10.Count)
                {
                    nameTextsUI[i].text = top10[i].playerName;
                    scoreTextsUI[i].text = top10[i].score.ToString();
                }
                else
                {
                    nameTextsUI[i].text = "";
                    scoreTextsUI[i].text = "";
                }
            }
        }

        public void OnstartButton()
        {
            namePanel.SetActive(false);
            fadeUI.SetActive(false);
            itemObjects.SetActive(true);
            cat.SetActive(true);
            isRank = false;
            GameManager.isPlay = true;

            gameManager.ScoreReset();   
        }
    }

    [System.Serializable]
    public struct PlayerScore
    {
        public string playerName;
        public int score;

        public PlayerScore(string name, int score)
        {
            playerName = name;
            this.score = score;
        }
    }
}