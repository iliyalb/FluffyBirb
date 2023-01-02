using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawn : MonoBehaviour
{
    public GameObject spawnObject;
    public float spawnDelay = 3;
    private float spawnTimer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < spawnDelay)
        {
            spawnTimer += Time.deltaTime;
        }
        else
        {
            SpawnPrefab();
            spawnTimer = 0;
        }
    }

    void SpawnPrefab()
    {
        Instantiate(spawnObject, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        
    }
}

