using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public GameObject titleScreen;
    public GameObject gameOverScreen;

    private void Start()
    {
        instance = this;
    }
    private void Update()
    {
        UpdateUI();
        GameOver();
    }
    private void UpdateUI()
    {
        scoreText.text = "Score: " + GameManager.Score;
        livesText.text = "Lives: " + Mathf.Clamp(GameManager.Lives, 0, 3);
    }
    private void GameOver()
    {
        if (GameManager.GameOver)
            gameOverScreen.SetActive(true);
    }
    public void DeactivateTitleScreen()
    {
        titleScreen.SetActive(false);
    }
}
