using UnityEngine;

public class BuildingMove : MonoBehaviour
{

    public float MoveSpeed = 3.0f;
    public AirplaneMoveScript airplaneMoveScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        airplaneMoveScript = GameObject.FindGameObjectWithTag("Character").GetComponent<AirplaneMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (airplaneMoveScript.isActive)
        {
            transform.position += Vector3.left * MoveSpeed * Time.deltaTime;

            if (transform.position.x <= -6.15)
            {
                Destroy(gameObject);
            }
        }
    }
}
