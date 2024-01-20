using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minYPosition;
    public float maxYPosition;
    public float delay = 1f;

    // Keep track of the last pipe's position
    private Vector3 lastPipePosition;

    void Start()
    {
        // Initial position for the first pipe
        lastPipePosition = new Vector3(21f, 0.0f, 0);
        InvokeRepeating("SpawnPipes", 0.0f, delay);
    }

    void SpawnPipes()
    {
        Debug.Log("Entering Spawning Pipes");
        // Generate a random Y position within the specified range
        float randomYPosition = Random.Range(minYPosition, maxYPosition);

        // Calculate the new position based on the last pipe's position
        Vector3 spawnPosition = lastPipePosition + new Vector3(7f, randomYPosition/*Random.Range(-1f, 1f)*/, 0);

        // Instantiate the new pipe at the calculated position
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        // Update the last pipe's position to the new one
        //lastPipePosition = spawnPosition;
        lastPipePosition.x = spawnPosition.x;

        Debug.Log("Pipe instantiated");
    }
}

