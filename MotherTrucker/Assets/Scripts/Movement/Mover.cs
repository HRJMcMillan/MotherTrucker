using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Variables
    [SerializeField] float maxSpeed = 20f;
    [SerializeField] float moveSpeed;
    [SerializeField] float inertiaModifier = 3f;
    [SerializeField] float kerbSidePositioninX = -8f;
    [SerializeField] float centerLanePositioninX = -5f;
    bool accelerating = false;
    bool stopped = true;

    // Cache
    Transform playerTransform;

    // Called on Start
    private void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    public void AccelerateDecelerate()
    {
        accelerating = !accelerating;
    }

    // Called every frame
    void Update()
    {
        if (accelerating && stopped)
        {
            Accelerate();
        }
        else if (!accelerating && !stopped)
        {
            Decelerate();
        }
        else
        {
            Move();
        }
    }

    // Reduces moveSpeed modified by inertiaModifier
    private void Decelerate()
    {
        moveSpeed -= Time.deltaTime * inertiaModifier;
        if (moveSpeed <= 0)
        {
            stopped = true;
        }
        if (playerTransform.position.x >= kerbSidePositioninX)
        {
            playerTransform.Translate(Vector3.right * inertiaModifier * Time.deltaTime);
        }
        Move();
    }

    // Increases moveSpeed modified by inertiaModifier
    private void Accelerate()
    {
        moveSpeed += Time.deltaTime * inertiaModifier;
        if (moveSpeed >= maxSpeed)
        {
            stopped = false;
        }
        if (playerTransform.position.x <= centerLanePositioninX && moveSpeed >= inertiaModifier)
        {
            playerTransform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        Move();
    }

    // Moves the player transform
    private void Move()
    {
        playerTransform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    // Returns whether the car is moving or not
    public bool Stopped()
    {
        return stopped;
    }
}
