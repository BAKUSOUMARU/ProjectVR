using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

namespace VRProject
{
public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private string _sceneName = null; 
        public void SceneChange()
        {
            if (_sceneName == null)
            {
                Debug.Log("Sceneの名前が登録させてないよ");
                return;
            }
            
            SteamVR_Fade.Start(new Color(0, 0, 0, 1), 2);
            SceneManager.LoadScene(_sceneName);
        }
    }
}
