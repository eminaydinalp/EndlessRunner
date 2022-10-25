using UnityEngine;
using Random = UnityEngine.Random;

namespace _Game.Scripts.Concrates.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] private EnemyController enemyController;

        [Range(0.5f, 3)] [SerializeField] private float minSpawnTime;
        [Range(5, 10)] [SerializeField] private float maxSpawnTime;

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

        private void Spawn()
        {
            Instantiate(enemyController, transform.position, transform.rotation, transform);
            
            ChangeSpawnTime();
        }

        private void ChangeSpawnTime()
        {
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
