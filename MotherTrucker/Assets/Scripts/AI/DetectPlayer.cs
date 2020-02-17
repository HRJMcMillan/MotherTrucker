using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    // Detects trigger colliders that intersect it and verifies if it's the player
    private void OnTriggerEnter(Collider other)
    {
        var player = GameObject.FindWithTag("Player");
        if (other.gameObject == player)
        {
            InteractWithPlayer();
        }
        else return;
    }

    private void InteractWithPlayer()
    {
        
    }
}
