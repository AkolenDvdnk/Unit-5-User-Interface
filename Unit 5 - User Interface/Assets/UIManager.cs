using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

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
            gameOverText.gameObject.SetActive(true);

    }
}
