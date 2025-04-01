using UnityEngine;

public class BuildingSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject BuildingPrefab;
    public float SpawnInterval = 2.0f;
    private float Timer = 0.0f;
    public AirplaneMoveScript airplaneMoveScript;
    void Start()
    {
        airplaneMoveScript = GameObject.FindGameObjectWithTag("Airplane").GetComponent<AirplaneMoveScript>();
    }
    void Update()
    {
        if (Timer >= SpawnInterval && airplaneMoveScript.isActive)
        {
            Instantiate(BuildingPrefab, new Vector3(transform.position.x, Random.Range(-3.66f, 0.2f), 0), Quaternion.identity);
            Timer = 0.0f;
        }
        else
        {
            Timer += Time.deltaTime;
        }
    }
}
