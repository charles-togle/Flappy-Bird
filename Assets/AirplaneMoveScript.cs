 using UnityEngine;

public class AirplaneMoveScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D AirPlane;
    public GameManagerScript gameManager;
    public float activeGravityScale = 0.8f; // Gravity scale when the game is active
    public float speed = 5f;
    public bool isDead = false;
    public bool isActive = false;
    [SerializeField] GameObject startGameScreen;
    
    void Start()
    {
        isActive = false;
        isDead = false;

        gameManager = GameObject.FindGameObjectWithTag("GameManager")?.GetComponent<GameManagerScript>();
        if (gameManager == null)
        {
            Debug.Log("GameManager not found or missing GameManagerScript component.");
        }

        AirPlane.gravityScale = isActive ? activeGravityScale : 0f;
    }

    // Update is called once per frame
    void Update()
    {
        AirPlane.gravityScale = isActive ? activeGravityScale : 0f;

        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            isActive = true;
            if (isActive)
            {
                AirPlane.linearVelocity = Vector2.up * speed;
                startGameScreen.SetActive(false);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();   
        isActive = false;
        isDead = true;
        AirPlane.bodyType = RigidbodyType2D.Static;

    }
}
