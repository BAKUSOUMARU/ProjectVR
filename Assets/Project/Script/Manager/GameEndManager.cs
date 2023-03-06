using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace VRProject
{
    public class GameEndManager : MonoBehaviour
    {
        [SerializeField] 
        private GamePointManager _gamePointManager;

        [SerializeField] 
        private int GameClearPoint;

        [SerializeField] 
        private GameObject _GameClearUI;

        [SerializeField] 
        private GameObject _GameOverUi;

        [SerializeField] 
        private GameObject _laserPointer;
        void Start()
        {
            GameManager.Instance.OnGameClear += GameClear;
            GameManager.Instance.OnGameOver += GameOver;
        }

        void GameClear()
        {
            _GameClearUI.SetActive(true);
            _laserPointer.SetActive(true);
        }

        void GameOver()
        {
            _GameOverUi.SetActive(true);
            _laserPointer.SetActive(true);
        }
    }
}
