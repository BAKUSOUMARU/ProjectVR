using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    [SerializeField]
    GameObject _player;

    [SerializeField]
    float _stopPingDistance = 1.8f;
        
    private NavMeshAgent _navMeshAgent;
    
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _navMeshAgent.destination = _player.transform.position;
        _navMeshAgent.stoppingDistance = _stopPingDistance;
    }
}
