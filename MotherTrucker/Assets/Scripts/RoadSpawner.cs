using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    // Variables
    float spawnOffset;
    
    // Cache
    RoadSpawnManager roadSpawnManager;

    private void OnTriggerEnter(Collider collider)
    {
        Vector3 spawnLocation = new Vector3
            (transform.parent.position.x, transform.parent.position.y, transform.parent.position.z + spawnOffset);
        GameObject nextSection = Instantiate(roadSpawnManager.GetRoad(), spawnLocation, transform.rotation);
        roadSpawnManager.SetOldSection(transform.parent.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        roadSpawnManager = FindObjectOfType<RoadSpawnManager>();
        spawnOffset = -transform.parent.Find("Tarmac").GetComponent<MeshRenderer>().bounds.size.z;
    }
}
