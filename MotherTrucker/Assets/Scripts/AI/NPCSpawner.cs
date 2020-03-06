using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    // Cache
    SpawnManager spawnManager;

    // Variables

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        Vector3 spawnLocation = spawnManager.GetNPCSpawn().transform.position;
        GameObject newNPC = Instantiate(spawnManager.GetNPCSkin(), spawnLocation, transform.rotation);
    }
}
