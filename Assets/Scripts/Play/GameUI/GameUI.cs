﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameUI : MonoBehaviour
{
    // GameUI's state machine
    public StateMachine stateMachine;

    // GameUI's states
    public GameUIStartState gameUIStartState;
    public GameUIPlayState gameUIPlayState;
    public GameUIEndState gameUIEndState;

    // GameUI's components
    public GameObject pauseMenu;
    
    private void Awake()
    {
        // Create GameUI's states
        gameUIStartState = new GameUIStartState(this);
        gameUIPlayState = new GameUIPlayState(this);
        gameUIEndState = new GameUIEndState(this);

        // Create GameUI's state machine
        stateMachine = new StateMachine(gameUIStartState);  
    }

    private void Start()
    {

    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
