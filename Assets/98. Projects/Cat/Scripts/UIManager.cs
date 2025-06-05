using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI; // 고양이 머리 위에 있는 이름
        public GameObject namePanel;

        public void OnstartButton()
        {
            if (inputField.text == "")
            {
                Debug.Log("입력한 것이 없음");
            }
            else
            {
                Debug.Log($"{nameTextUI} 입력");
                nameTextUI.text = inputField.text;
                namePanel.SetActive(false);
            }
        }
    }
}