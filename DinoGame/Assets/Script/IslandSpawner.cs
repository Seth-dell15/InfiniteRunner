using UnityEngine;

public class IslandSpawner : MonoBehaviour
{
    public GameObject islandPrefab;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 3.0f;

    public float minY = -2f;
    public float maxY = 2f;

    void Start()
    {
        Invoke("Spawn", 0.5f); // Lance la première île rapidement
    }

    void Spawn()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);

        GameObject newIsland = Instantiate(islandPrefab, spawnPos, Quaternion.identity);

        // On appelle notre nouveau script pour régler la taille
        float randomWidth = Random.Range(2f, 6f);
        newIsland.GetComponent<IslandBuilder>().SetSize(randomWidth);

        float nextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
        Invoke("Spawn", nextSpawn);
    }
}