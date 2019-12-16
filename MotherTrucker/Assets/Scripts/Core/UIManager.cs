using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Cache
    Image image;
    Text text;

    // Variables
    bool uIVisible = false;
    
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponentInChildren<Image>();
        text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ToggleUI();
        }
    }

    private void ToggleUI()
    {
        uIVisible = !uIVisible;
    }
}
