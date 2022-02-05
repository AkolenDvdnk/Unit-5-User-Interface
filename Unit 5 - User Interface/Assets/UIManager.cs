using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        UpdateScoreUI();
    }
    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + GameManager.Score;
    }
}
