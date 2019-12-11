using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawnManager : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject[] roadSections;
    GameObject oldSection;

    public GameObject GetRoad()
    {
        GameObject nextSection = roadSections[Random.Range(0, roadSections.Length)];
        return nextSection;
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
