using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI scoreText;
    public GameObject titleScreen;
    public GameObject gameOverScreen;

    private void Start()
    {
        instance = this;
    }
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
            gameOverScreen.SetActive(true);
    }
    public void DeactivateTitleScreen()
    {
        titleScreen.SetActive(false);
    }
}
