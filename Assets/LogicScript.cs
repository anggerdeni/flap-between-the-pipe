using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    private int score;
    public GameObject gameOverScreen;
    public GameObject pipeSpawner;

    private GameObject[] pipes;

    // Start is called before the first frame update
    void Start()
    {
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;

        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Destroy(pipeSpawner);

        pipes = GameObject.FindGameObjectsWithTag("Pipe");
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].GetComponent<PipeMoveScript>().isGameOver = true;
        }

        pipes = new GameObject[0];
    }
}
