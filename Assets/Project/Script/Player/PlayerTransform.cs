using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    public static Transform Player { get; private set; }

    [SerializeField] private Transform _player;

    private void Awake()
    {
        Player = _player;
    }
}

