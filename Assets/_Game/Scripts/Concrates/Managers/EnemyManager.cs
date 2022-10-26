using System.Collections.Generic;
using _Game.Scripts.Concrates.Controllers;
using _Game.Scripts.Concrates.Utilities;
using UnityEngine;

namespace _Game.Scripts.Concrates.Managers
{
    public class EnemyManager : Singleton<EnemyManager>
    {

        [SerializeField] private EnemyController _enemyController;
        [SerializeField] private int enemyCount;
        private Queue<EnemyController> _enemyControllers = new Queue<EnemyController>();
        
        private void InitialEnemy()
        {
            for (int i = 0; i < enemyCount; i++)
            {
                EnemyController newEnemy = Instantiate(_enemyController);
                _enemyControllers.Enqueue(newEnemy);
                newEnemy.gameObject.SetActive(false);
            }
        }

        public EnemyController GetEnemyFromPool(Vector3 position, Quaternion rotation)
        {
            if (_enemyControllers.Count == 0)
            {
                InitialEnemy();
            }
            
            EnemyController enemyController = _enemyControllers.Dequeue();
            enemyController.gameObject.SetActive(true);
            enemyController.gameObject.transform.position = position;
            enemyController.gameObject.transform.rotation = rotation;
            _enemyControllers.Enqueue(enemyController);

            return enemyController;
        }

        public void SetEnemyActive(EnemyController enemyController)
        {
            enemyController.gameObject.SetActive(false);
        }

    }
}
