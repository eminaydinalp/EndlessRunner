using System;
using _Game.Scripts.Concrates.ScriptableObjects;
using _Game.Scripts.Concrates.Utilities;
using UnityEngine;

namespace _Game.Scripts.Concrates.Managers
{
    public class LevelManager : MonoBehaviour
    {
        public static LevelManager Instance;
        
        public LevelDifficultyData[] levelDifficultyDatas;

        public LevelDifficultyData CurrentLevelDifficulty => levelDifficultyDatas[GameManager.Instance.LevelDifficultyIndex];

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            RenderSettings.skybox = CurrentLevelDifficulty.Skybox;
            Instantiate(CurrentLevelDifficulty.FloorPrefab);
            Instantiate(CurrentLevelDifficulty.EnemySpawnersPrefab);
            EnemyManager.Instance.AddDelayTime = CurrentLevelDifficulty.AddDelayTime;
        }
    }
}
