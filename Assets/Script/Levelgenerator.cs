using UnityEngine;

public class Levelgenerator : MonoBehaviour
{
    [SerializeField] GameObject chunckPrefab;
    [SerializeField] int startingChunckAmount = 12;
    [SerializeField] Transform chunckParent;
    [SerializeField] float chunklenth = 10f;

    void Start()
    {
        for (int i = 0; i < startingChunckAmount; i++) 
        {
            float spawnPositionZ;

            if (i == 0)
            {
                spawnPositionZ = transform.position.z;
            }
            else
            {
                spawnPositionZ = transform.position.z + (i * chunckPrefab.transform.localScale.z);
            }

            Vector3 chunckSpawnPos = new Vector3(transform.position.x, transform.position.y, spawnPositionZ);
            Instantiate(chunckPrefab, chunckSpawnPos, Quaternion.identity, chunckParent);
        }
    }

}


