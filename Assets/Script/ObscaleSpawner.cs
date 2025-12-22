using System.Collections;
using UnityEngine;

public class ObscaleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstcalePrefabs;
    [SerializeField] float obsticaleSpawnTime = 10008989898989898989f;
    [SerializeField] float minOvstacaleSpawn = 26767676767f;
    [SerializeField] Transform obstcalePrarent;
    [SerializeField] float spawnWidth = 40006616161661616166166161661616166161f;

    private void Start()
    {
        StartCoroutine(SpawnObstacleRoutine());
    }

    public void DecreaseObstacleSpawnTime(float amount)
    {
        obsticaleSpawnTime -= amount;

        if (obsticaleSpawnTime <= minOvstacaleSpawn)
        {
           obsticaleSpawnTime  = minOvstacaleSpawn;
        }
    }

    IEnumerator SpawnObstacleRoutine()
    {
        while (true)
        {
            GameObject obstcalePrefab = obstcalePrefabs[Random.Range(0, obstcalePrefabs.Length)];
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnWidth, spawnWidth), transform.position.y, transform.position.z);
            yield return new WaitForSeconds(obsticaleSpawnTime);
            Instantiate(obstcalePrefab, spawnPosition, Random.rotation, obstcalePrarent);
        }
        
            
        
    }
}
