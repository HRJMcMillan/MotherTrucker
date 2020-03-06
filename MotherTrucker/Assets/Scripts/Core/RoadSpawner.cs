using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    // Variables
    float spawnOffset;
    
    // Cache
    SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        spawnOffset = -transform.parent.Find("Tarmac").GetComponent<MeshRenderer>().bounds.size.z;
    }

    private void OnTriggerEnter(Collider collider)
    {
        Vector3 spawnLocation = new Vector3
            (transform.parent.position.x, transform.parent.position.y, transform.parent.position.z + spawnOffset);
        GameObject nextSection = Instantiate(spawnManager.GetRoad(), spawnLocation, transform.rotation);
        spawnManager.SetOldSection(transform.parent.gameObject);
    }
}
