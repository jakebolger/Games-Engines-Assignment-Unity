using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnPos;
    public GameObject spawnee;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
    }
}
