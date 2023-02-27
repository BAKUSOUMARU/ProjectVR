using UnityEngine;
using UnityEngine.AI;
public class EnemyMove : MonoBehaviour
{

    [SerializeField]
    private float _moveSpeed = 5f;

    [SerializeField]
    float _stopPingDistance = 1.8f;
        
    private NavMeshAgent _navMeshAgent;
    
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }

    private void OnDisable()
    {
        Debug.Log("切られた");
    }

    void Move()
    {
        _navMeshAgent.destination = PlayerTransform.Player.position;
        _navMeshAgent.speed = _moveSpeed;
        _navMeshAgent.stoppingDistance = _stopPingDistance;
    }
}
