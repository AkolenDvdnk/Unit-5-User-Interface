using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Score;
    public static int Lives;
    public static bool GameOver = false;

    public List<GameObject> targets;

    private float spawnRate = 1f;

    private IEnumerator SpawnTarget()
    {
        while (!GameOver)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    public int UpdateScoreValue(int value)
    {
        return Score += value;
    }
    public void StartGame(int difficulty)
    {
        Score = 0;
        Lives = 3;
        spawnRate /= difficulty;

        UIManager.instance.DeactivateTitleScreen();

        StartCoroutine(SpawnTarget());
    }
}
