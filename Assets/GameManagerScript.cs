using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerScript : MonoBehaviour
{

    public TMP_Text scoreText;
    private int startingScore = 0;
    public GameObject gameOverScreen;
    [SerializeField] GameObject startGameScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = startingScore.ToString();
        gameOverScreen.SetActive(false);
        
        if (PlayerPrefs.GetString("isGameRestarted") == "true")
        {
            startGameScreen.SetActive(false);
            PlayerPrefs.SetString("isGameRestarted", "false");
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetString("isGameRestarted", "false");
            PlayerPrefs.Save();
            Application.Quit();
        } 
    }

    public void AddScore()
    {
        startingScore++;
        scoreText.text = startingScore.ToString();
    }

    public void StartGame(){
        startGameScreen.SetActive(false);
    }

    public void RestartGame()
    {
        PlayerPrefs.SetString("isGameRestarted", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);

    }
}
