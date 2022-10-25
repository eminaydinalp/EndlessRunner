using _Game.Scripts.Concrates.Controllers;
using UnityEngine;

namespace _Game.Scripts.Concrates.Movement
{
    public class VerticalMove
    {
        private EnemyController _enemyController;
        private float _moveSpeed;

        public VerticalMove(EnemyController enemyController)
        {
            _enemyController = enemyController;
            _moveSpeed = _enemyController.MoveSpeed;
        }

        public void MoveVertical(float direction = 1)
        {
            _enemyController.transform.Translate(Vector3.back *(direction * Time.deltaTime * _moveSpeed));
        }

    }
}
