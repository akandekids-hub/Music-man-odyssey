using System.Collections;
using UnityEngine;

public class ObscaleSpawner : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] float objectSpawnTime = 1f;

    int objectSpawned = 0;

    private void Start()
    {
        StartCoroutine(SpawnObstacleRoutine());
    }

    IEnumerator SpawnObstacleRoutine()
    {
        while (objectSpawned < 50)
        {
            yield return new WaitForSeconds(objectSpawnTime);
            Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
            objectSpawned++;
        }
    }

}
