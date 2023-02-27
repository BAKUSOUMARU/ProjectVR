
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectPool : SingletonMonoBehaviour<ObjectPool>
{
    [FormerlySerializedAs("_objParams")] [SerializeField] 
    private ObjectPoolParams _objParam;

    [SerializeField] 
    private Transform _poolprefabPArent;

    private List<Pool> _pool = new List<Pool>();

    private int _poolCountIndex = 0;

    protected override void Awake()
    {
        base.Awake();
        
    }

    private void CreatePool()
    {
        if (_poolCountIndex >= _objParam.Params.Count)
        {
            return;
        }

        for (int i = 0; i < _objParam.Params[_poolCountIndex].MaxCount; i++)
        {
            var Prefab = Instantiate(_objParam.Params[_poolCountIndex].Prefab, _poolprefabPArent.transform);
            
            Prefab.gameObject.SetActive(false);
            _pool.Add(new Pool{Prefab = Prefab, Name = _objParam.Params[_poolCountIndex].Name});
        }

        _poolCountIndex++;
        CreatePool();
    }

    /// <summary>
    /// オブジェクトを使いたいときに呼び出す関数
    /// </summary>
    /// <param name="name">使いたいオブジェクトの名前</param>
    /// <param name="pos">生成したい場所</param>
    /// <returns>呼び出したゲームオブジェクト</returns>
    public GameObject UseObject(string name, Vector3 pos)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Debug.Log("名前が指定されてないよ");
            return null;
        }

        foreach (var pool in _pool)
        {
            if (pool.Prefab.gameObject.activeSelf== false && pool.Name == name)
            {
                pool.Prefab.transform.position = pos;
                pool.Prefab.SetActive(true);
                return pool.Prefab;
            }
        }

        var findedObject = _objParam.Params.Find(x => x.Name == name);

        if (findedObject == null)
        {
            Debug.LogError($"{name}というオブジェクトが見つかりませんでした");
            return null;
        }

        var prefab = Instantiate(findedObject.Prefab, _poolprefabPArent.transform);
        prefab.transform.position = pos;
        prefab.SetActive(true);
        _pool.Add(new Pool{Prefab = prefab, Name = name});
        return prefab;
    }

    /// <summary>
    /// オブジェクトを使いたいときに呼び出す関数
    /// 指定した型引数<T>を戻り値として返す
    /// </summary>
    /// <param name="name">使いたいオブジェクトの名前</param>
    /// <param name="pos">生成したい場所</param>
    /// <returns>呼び出したゲームオブジェクト</returns>
    public T UseObject<T>(string name, Vector3 pos) where T : Component
    {
        if (UseObject(name,pos).TryGetComponent(out  T component))
        {
            return component;
        }
        else
        {
            Debug.LogError($"{typeof(T).Name}を取得しようとしましたが取得出来ませんでした");
            return null;
        }
    }
    
    class Pool
    {
        public GameObject Prefab { get; set; }
        
        public string Name { get; set;}
    }

    [Serializable]
    public class ObjectPoolParams
    {
        public List<ObjectpoolParam> Params => _params;

        [SerializeField] 
        private List<ObjectpoolParam> _params;
        
        [Serializable]
        public class ObjectpoolParam
        {
            public string Name => name;
            public GameObject Prefab => prefab;
            public int MaxCount => maxCount;

            [SerializeField] 
            private string name;

            [SerializeField] 
            private GameObject prefab;

            [SerializeField] 
            private int maxCount;
        }

    }
    
}

