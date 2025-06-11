using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public TMP_InputField inputField;
        public TextMeshProUGUI[] nameTextsUI;
        public TextMeshProUGUI[] scoreTextsUI;
        public GameObject namePanel;
        public GameObject fadeUI;

        private List<PlayerScore> playerScores = new List<PlayerScore>();

        public void OnRankButton()
        {
            string playerName = inputField.text;

            if (string.IsNullOrWhiteSpace(playerName))
            {
                Debug.Log("입력한 것이 없음");
                return;
            }

            // 점수 저장
            playerScores.Add(new PlayerScore(playerName, GameManager.score));

            // 높은 점수 순으로 정렬
            playerScores = playerScores.OrderByDescending(ps => ps.score).ToList();

            // 상위 10개만 추리기
            for (int i = 0; i < 10; i++)
            {
                if (i < playerScores.Count)
                {
                    nameTextsUI[i].text = playerScores[i].playerName;
                    scoreTextsUI[i].text = playerScores[i].score.ToString();
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

            // 고양이 재배치 + 시간, 과일갯수 리셋
            
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