using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Button startButton;
    public Button overButton;
    public GameObject OverCanvas;
    public static bool isStart = false;

    void Start()
    {
        startButton.onClick.AddListener(StartGame); 
        overButton.onClick.AddListener(OverGame);
    }

    void Update()
    {
        if(isStart)
        {
            startButton.gameObject.SetActive(false);
        }
        if(BirdController.isDead)
        {
            OverCanvas.gameObject.SetActive(true);
        }
    }

    private void StartGame()
    {
        isStart = true;
    }

    private void OverGame()
    {
        UIManager.isStart = false;
        BirdController.isDead = false;
        SceneManager.LoadScene("Game");
    }
}
