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
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);

        }

            if (_rayfireMan.storage.storageList.Count == 0)
            return;
        
        var i = _rayfireMan.storage.storageList.Count - 1;
        a= Å@_rayfireMan.storage.storageList[i].GetChild(0);

        
    }
}
