using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    [SerializeField] 
    private string _spawnEnemyName = null;

    [SerializeField] 
    private Transform _spawnTransform;

    [SerializeField]
    private int _spawnValue;

    [SerializeField] 
    private int _spawnInterval;
     void Start()
    {
        SpawnAsync().Forget();
    }

    async UniTask SpawnAsync()
    {
        for (int i = 0; i < _spawnValue; i++)
        {
            ObjectPool.Instance.UseObject(_spawnEnemyName, _spawnTransform.position);
            await UniTask.Delay(TimeSpan.FromSeconds(_spawnInterval));
        }
    }
}
