using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using VRProject;

namespace VRProject
{
    public class PlayerTransform : MonoBehaviour
    {
        public static Transform Player { get; private set; } 

        [SerializeField] private Transform _player;

        private void FixedUpdate()
        {
            Player = _player;
        }
    }
}

