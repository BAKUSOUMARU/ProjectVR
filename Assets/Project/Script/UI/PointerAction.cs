using Unity.VisualScripting;
using Valve.VR.Extras;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace VRProject
{
    public class PointerAction : MonoBehaviour
    {
        //右手用
        public SteamVR_LaserPointer laserPointer;
        //左手用
        public SteamVR_LaserPointer laserPointer2;

        void Awake()
        {
            laserPointer.PointerIn += PointerInside;
            laserPointer.PointerOut += PointerOutside;
            laserPointer.PointerClick += PointerClick;
            laserPointer2.PointerIn += PointerInside;
            laserPointer2.PointerOut += PointerOutside;
            laserPointer2.PointerClick += PointerClick;
        }

        //レーザーポインターをtargetに焦点をあわせてトリガーをひいたとき
        public void PointerClick(object sender, PointerEventArgs e)
        {
            if (e.target.TryGetComponent(out Button test))
            {
                test.onClick.Invoke();
                Debug.Log("できた!");
            }
        }

        //レーザーポインターがtargetに触れたとき
        public void PointerInside(object sender, PointerEventArgs e)
        {
            if (e.target.TryGetComponent(out Button test))
            {
                ColorBlock colorBlock = new ColorBlock();
                colorBlock.normalColor = Color.gray;
                colorBlock.colorMultiplier = test.colors.colorMultiplier;
                test.colors = colorBlock;
            }
        }

        //レーザーポインターがtargetから離れたとき
        public void PointerOutside(object sender, PointerEventArgs e)
        {
            if (e.target.TryGetComponent(out Button test))
            {
                ColorBlock colorBlock = new ColorBlock();
                colorBlock.normalColor = Color.white;
                colorBlock.colorMultiplier = test.colors.colorMultiplier;
                test.colors = colorBlock;
            }
        }
    }
}

  

