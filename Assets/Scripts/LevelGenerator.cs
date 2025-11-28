
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Transform player;
    public GameObject[] levelPrefabs;
    public float distanceToSpawn = 20f;
    public float levelOffset = 15f;

    private float nextSpawnZ = 0f;

    void Update()
    {
        if (player.position.z + distanceToSpawn > nextSpawnZ)
            SpawnLevel();
    }

    void SpawnLevel()
    {
        int index = Random.Range(0, levelPrefabs.Length);
        Instantiate(levelPrefabs[index], new Vector3(0, 0, nextSpawnZ), Quaternion.identity);
        nextSpawnZ += levelOffset;
    }
}
