using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    //

    // Cache
    Mover mover;
    
    // Start is called before the first frame update
    void Start()
    {
        mover = GetComponent<Mover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mover.AccelerateDecelerate();
        }
    }
}
