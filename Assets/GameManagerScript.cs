using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerScript : MonoBehaviour
{

    public TMP_Text scoreText;
    private int startingScore = 0;
    public GameObject gameOverScreen;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = startingScore.ToString();
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore()
    {
        startingScore++;
        scoreText.text = startingScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);

    }
}
