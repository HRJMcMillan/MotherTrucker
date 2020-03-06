using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject[] roadSections;
    [SerializeField] GameObject[] nPCSpawns;
    [SerializeField] GameObject[] nPCSkins;
    GameObject oldSection;

    public GameObject GetRoad()
    {
        GameObject nextSection = roadSections[Random.Range(0, roadSections.Length)];
        return nextSection;
    }

    public GameObject GetNPCSpawn()
    {
        GameObject spawnLocation = nPCSpawns[Random.Range(0, nPCSpawns.Length)];
        return spawnLocation;
    }

    public GameObject GetNPCSkin()
    {
        GameObject nPCSkin = nPCSkins[Random.Range(0, nPCSkins.Length)];
        return nPCSkin;
    }

    public void SetOldSection(GameObject currentSection)
    {
        DestroyOldSection();
        oldSection = currentSection;
    }

    private void DestroyOldSection()
    {
        if (!oldSection) return;
        Destroy(oldSection);
    }


}
