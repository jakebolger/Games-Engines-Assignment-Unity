using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{

    public GameObject Spawner;
    public float spawnTime;
    public float spawnDelay;
    public bool stopSpawning;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(Spawner, transform.position, transform.rotation);

        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
