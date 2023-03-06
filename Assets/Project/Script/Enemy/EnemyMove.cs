using UnityEngine;
using UnityEngine.AI;

namespace VRProject
{
    public class EnemyMove : MonoBehaviour
    {

        [SerializeField]
        private float _moveSpeed = 5f;

        [SerializeField]
        float _stopPingDistance = 1.8f;

        [SerializeField] 
        private int _upGamepointCount = 1;
            
        private NavMeshAgent _navMeshAgent;

        private bool IsSopwn;
        
        void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            Move();
        }
        
        private void OnDisable()
        {
            if (IsSopwn)
            {
                Debug.Log("切られた");
                GamePointManager.Instance.GamePointUp(_upGamepointCount);
                return;
            }
            IsSopwn = true;
            Debug.Log("生まれた");
        }

        void Move()
        {
            _navMeshAgent.destination = PlayerTransform.Player.position;
            _navMeshAgent.speed = _moveSpeed;
            _navMeshAgent.stoppingDistance = _stopPingDistance;
        }
    }
}
