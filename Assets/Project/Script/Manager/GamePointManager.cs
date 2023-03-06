using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRProject
{
    public class GamePointManager : SingletonMonoBehaviour<GamePointManager>
    {
        public int GamePoint => _gamePoint;

        private int _gamePoint = 0;
        
        public void GamePointUp(int upPoint)
        {
            _gamePoint += upPoint;
        }
    }
}
