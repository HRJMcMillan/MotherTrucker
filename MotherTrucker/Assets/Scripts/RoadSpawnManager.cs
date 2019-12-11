using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawnManager : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject[] roadSections;

    public GameObject GetRoad()
    {
        GameObject nextSection = roadSections[Random.Range(0, roadSections.Length)];
        return nextSection;
    }
}
