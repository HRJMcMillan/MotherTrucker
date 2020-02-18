using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    // Cache
    Mover mover;

    // Variables
    bool safeApproach;
    bool inRangeOfPlayer;
    GameObject player;
    Transform playerInteract;
    [SerializeField] float rawMoveSpeed = 1f;

    // Called on start
    private void Start()
    {
        mover = FindObjectOfType<Mover>();
        playerInteract = FindObjectOfType<AI_Interact>().GetComponentInParent<Transform>();
    }

    // Called every frame
    private void Update()
    {
        InteractWithPlayer();
    }

    // Detects trigger colliders that intersect it and verifies if it's the player
    private void OnTriggerEnter(Collider other)
    {
        player = GameObject.FindWithTag("Player");
        if (other.gameObject == player)
        {
            inRangeOfPlayer = true;
        }
        else return;
    }

    // Detects trigger exit and updates status
    private void OnTriggerExit(Collider other)
    {
        var player = GameObject.FindWithTag("Player");
        if (other.gameObject == player)
        {
            inRangeOfPlayer = false;
        }
        else return;
    }

    private void InteractWithPlayer()
    {
        safeApproach = mover.Stopped();
        if(safeApproach && inRangeOfPlayer)
        {
            MoveToPlayer();
            Talk();
        }
    }

    private void Talk()
    {
        Debug.Log("Hello, I don't have anything to say!");
    }

    private void MoveToPlayer()
    {
        float moveSpeed = rawMoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerInteract.position, moveSpeed);
    }
}
