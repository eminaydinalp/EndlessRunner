using System.Collections.Generic;
using _Game.Scripts.Concrates.Managers;
using UnityEngine;

namespace _Game.Scripts.Concrates.Utilities
{
    public abstract class ObjectPooler : MonoBehaviour
    {
        [System.Serializable]
        public class Pool
        {
            public string type;
            public GameObject prefab;
            public int size;
        }
        
        public List<Pool> pools;
        public Dictionary<string, Queue<GameObject>> poolDictionary;
        
        GameObject objectToSpawn;
        
        private void Start()
        {
            poolDictionary = new Dictionary<string, Queue<GameObject>>();

            foreach (Pool pool in pools)
            {
                Queue<GameObject> objectPool = new Queue<GameObject>();

                GameObject parent = new GameObject();
                parent.name = pool.type;
                for (int i = 0; i < pool.size; i++)
                {
                    GameObject obj = Instantiate(pool.prefab,parent.transform);
                    obj.SetActive(false);
                    objectPool.Enqueue(obj);
                }

                poolDictionary.Add(pool.type, objectPool);
            }
        }

        public GameObject SpawnFromPool(string type, Vector3 position, Quaternion rotation)
        {
            if (!poolDictionary.ContainsKey(type))
            {
                Debug.LogWarning("Pool with type : " + type + " doesn't exist.");
                return null;
            }

            objectToSpawn = poolDictionary[type].Dequeue();
            objectToSpawn.SetActive(true);
            objectToSpawn.transform.position = position;
            objectToSpawn.transform.rotation = rotation;

            poolDictionary[type].Enqueue(objectToSpawn);

            return objectToSpawn;
        }

        public void DeActiveGameObjet(GameObject objectToDeActive)
        {
            objectToDeActive.SetActive(false);
        }
    
    }
}