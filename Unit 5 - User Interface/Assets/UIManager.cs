using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverUI;

    private void Update()
    {
        UpdateScoreUI();
        GameOver();
    }
    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + GameManager.Score;
    }
    private void GameOver()
    {
        if (GameManager.GameOver)
            gameOverUI.SetActive(true);
    }
}
