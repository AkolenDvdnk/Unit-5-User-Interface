using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    public int difficulty;

    private Button button;
    private GameManager gameManager;

    private void Awake()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Start()
    {
        button.onClick.AddListener(SetDifficulty);
    }
    private void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
