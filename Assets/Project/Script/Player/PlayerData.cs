using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int PlayerPoint => _PlayerPoint;

    private int _PlayerPoint = 0;
    
    public void PlayerPointUp(int upPoint)
    {
        _PlayerPoint += upPoint;
    }
}
