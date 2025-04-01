using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject CloudPrefab;
    public float SpawnInterval;
    private float Timer = 0.0f;
    public AirplaneMoveScript airplaneMoveScript;
    void Start()
    {
        airplaneMoveScript = GameObject.FindGameObjectWithTag("Character").GetComponent<AirplaneMoveScript>();
    }
    void Update()
    {
        if (Timer >= SpawnInterval && airplaneMoveScript.isActive)
        {
            Instantiate(CloudPrefab, new Vector3((float)8.03, (float)-3.78, 0), Quaternion.identity);
            Timer = 0.0f;
        }
        else
        {
            Timer += Time.deltaTime;
        }
    }
}
