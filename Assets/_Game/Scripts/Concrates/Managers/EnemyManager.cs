using _Game.Scripts.Concrates.Utilities;
using UnityEngine;

namespace _Game.Scripts.Concrates.Managers
{
    public class EnemyManager : ObjectPooler
    {
        public static EnemyManager Instance;
        
        private int _enemyIndex;

        public int EnemyIndex
        {
            get => _enemyIndex;
            private set
            {
                if (value <= pools.Count)
                {
                    _enemyIndex = value;
                }
            }
        }

        [SerializeField] private float addDelayTime;

        public float AddDelayTime
        {
            get => addDelayTime;
            set => addDelayTime = value;
        }

        private float _time;

        private float _timeForIncrease;
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                //DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            if(_enemyIndex == pools.Count) return;
            
            if (_time < Time.time)
            {
                _time = Time.time + addDelayTime;
                IncreaseEnemyIndex();
            }
        }

        private void IncreaseEnemyIndex()
        {
            EnemyIndex++;
        }
        
    }
}
