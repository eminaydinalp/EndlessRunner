using _Game.Scripts.Concrates.Controllers;
using UnityEngine;

namespace _Game.Scripts.Concrates.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Level Data",menuName = "Create Level Data")]
    public class LevelDifficultyData : ScriptableObject
    {
        [SerializeField] private FloorController floorPrefab;
        [SerializeField] private GameObject enemySpawnersPrefab;
        [SerializeField] private Material skybox;
        [SerializeField] private float enemySpeed;
        [SerializeField] private float addDelayTime;

        public float EnemySpeed
        {
            get => enemySpeed;
            set => enemySpeed = value;
        }

        public FloorController FloorPrefab
        {
            get => floorPrefab;
            set => floorPrefab = value;
        }

        public GameObject EnemySpawnersPrefab
        {
            get => enemySpawnersPrefab;
            set => enemySpawnersPrefab = value;
        }

        public Material Skybox
        {
            get => skybox;
            set => skybox = value;
        }

        public float AddDelayTime
        {
            get => addDelayTime;
            set => addDelayTime = value;
        }
        
        
    }
}
