using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipes;

    public float spawnRate = 2.5f;
    public float heightOffset = 8;
    private float timer = 0;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }

    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highiestPoint = transform.position.y + heightOffset;
        
        Instantiate(Pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highiestPoint), 0), transform.rotation);

    }

}