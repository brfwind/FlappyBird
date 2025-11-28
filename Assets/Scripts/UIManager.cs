using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button startButton;
    public static bool isStart = false;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);    
    }

    void Update()
    {
        if(isStart)
        {
            startButton.gameObject.SetActive(false);
        }
    }

    private void StartGame()
    {
        isStart = true;
    }

  
}
