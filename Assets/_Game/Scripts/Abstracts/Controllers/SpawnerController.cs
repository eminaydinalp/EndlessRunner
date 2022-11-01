using UnityEngine;

namespace _Game.Scripts.Abstracts.Controllers
{
    public abstract class SpawnerController : MonoBehaviour
    {
        [Range(0.5f, 3)] [SerializeField] private float minSpawnTime;
        [Range(2, 10)] [SerializeField] private float maxSpawnTime;

        [SerializeField] private float spawnTime;

        private float _currentTime;
        
        private void OnEnable()
        {
            ChangeSpawnTime();
        }
        
        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime >= spawnTime)
            {
                _currentTime = 0;
                
                Spawn();
            }
        }
        
        protected virtual void Spawn()
        {
            ChangeSpawnTime();
        }
        
        protected virtual void ChangeSpawnTime()
        {
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    
    }
}
