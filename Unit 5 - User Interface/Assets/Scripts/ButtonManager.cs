using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Retry()
    {
        GameManager.GameOver = false;
        GameManager.Score = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
