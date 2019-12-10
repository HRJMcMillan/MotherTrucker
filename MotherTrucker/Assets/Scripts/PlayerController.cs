using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    float moveSpeed = 5;

    // Cache
    Transform playerTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        playerTransform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
