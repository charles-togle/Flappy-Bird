using UnityEngine;

public class ScoreAdderScript : MonoBehaviour
{
    
    public GameManagerScript gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager")?.GetComponent<GameManagerScript>();
        if (gameManager == null)
        {
            Debug.Log("GameManager not found or missing GameManagerScript component.");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Score added");
        gameManager.AddScore();
    }
}
