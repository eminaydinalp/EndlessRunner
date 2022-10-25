using System;
using System.Security.Cryptography;
using _Game.Scripts.Concrates.Movement;
using UnityEngine;

namespace _Game.Scripts.Concrates.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        private VerticalMove _verticalMove;
        
        [SerializeField] private float moveSpeed;

        [SerializeField] private float maxLifeTime;

        private float _currentTime;

        public float MoveSpeed => moveSpeed;

        private void Awake()
        {
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
            _verticalMove.MoveVertical();
        }

        void SelfDestroyer()
        {
            Destroy(gameObject);
        }
    }
}
