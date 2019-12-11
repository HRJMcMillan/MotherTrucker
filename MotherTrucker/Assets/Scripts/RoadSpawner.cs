using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    // Cache
    RoadSpawnManager roadSpawnManager;

    private void OnTriggerEnter(Collider collided)
    {
        Transform spawnLocation = transform;
        GameObject nextSection = Instantiate(roadSpawnManager.GetRoad(), spawnLocation.position, transform.rotation);
        print(nextSection.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        roadSpawnManager = FindObjectOfType<RoadSpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
