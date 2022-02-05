using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Retry()
    {
        GameManager.GameOver = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
