using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RayFire;

public class test : MonoBehaviour
{

    RayfireMan _rayfireMan;

     Transform a;
    // Start is called before the first frame update
    void Start()
    {
        _rayfireMan = GameObject.Find("RayFireMan").GetComponent<RayfireMan>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rayfireMan.storage.storageList.Count == 0)
        return;
        
        var i = _rayfireMan.storage.storageList.Count - 1;
        a= 　_rayfireMan.storage.storageList[i].GetChild(0);
        
        if (a.name == "Capsule"+ "_" + 0)
        {
            Debug.Log("こっち");
            Debug.Log(a.name);
        }
        else if (a.name == "Cube" + "_" + 0)
        {
            Debug.Log("あっち");
            Debug.Log(a.name);
        }
    }

    void aa()
    {
        _ = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
