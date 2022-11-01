using _Game.Scripts.Abstracts.Controllers;
using _Game.Scripts.Concrates.Managers;
using _Game.Scripts.Concrates.Movement;
using UnityEngine;
using CharacterController = _Game.Scripts.Abstracts.Controllers.CharacterController;

namespace _Game.Scripts.Concrates.Controllers
{
    public class EnemyController : CharacterController, IEntityController
    {
        private VerticalMove _verticalMove;

        [SerializeField] private float maxLifeTime;

        private float _currentTime;
        
        private void Awake()
        {
            SetMoveSpeed();
            _verticalMove = new VerticalMove(this);
        }

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime >= maxLifeTime)
            {
                _currentTime = 0;
                
                SelfDestroyer();
            }
        }

        private void FixedUpdate()
        {
            _verticalMove.Move();
        }

        void SelfDestroyer()
        {
            EnemyManager.Instance.DeActiveGameObjet(gameObject);
        }

        private void SetMoveSpeed()
        {
            MoveSpeed = LevelManager.Instance.CurrentLevelDifficulty.EnemySpeed;
        }
    }
}
