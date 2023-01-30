using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{

    public event Action OnGameClear;

    public event Action OnGameOver;

    private bool IsGameFinish;

    public void GameClear()
    {
        if (IsGameFinish)
        {
            
        }
    }
}
