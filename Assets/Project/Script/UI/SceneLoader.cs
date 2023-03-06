using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Valve.VR;

namespace VRProject
{
    public class SceneLoader : MonoBehaviour
    {
        public void FadeSceneChange(string sceneName)
        {
            SteamVR_Fade.Start(new Color(0, 0, 0, 1), 2);
            SceneManager.LoadScene(sceneName);
            SteamVR_Fade.Start(new Color(0, 0, 0, 0), 2);
            
        }
    }
}
