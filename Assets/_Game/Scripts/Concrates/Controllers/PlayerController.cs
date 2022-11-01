using System;
using _Game.Scripts.Abstracts;
using _Game.Scripts.Abstracts.Controllers;
using _Game.Scripts.Concrates.Animations;
using _Game.Scripts.Concrates.Inputs;
using _Game.Scripts.Concrates.Managers;
using _Game.Scripts.Concrates.Movement;
using UnityEngine;
using UnityEngine.InputSystem;
using CharacterController = _Game.Scripts.Abstracts.Controllers.CharacterController;

namespace _Game.Scripts.Concrates.Controllers
{
    public class PlayerController : CharacterController, IEntityController
    {
        private HorizontalMovement _horizontalMovement;
        private JumpWithRigidbody _jumpWithRigidbody;
        private IInputReader _inputReader;
        private PlayerAnims _playerAnims;

        [SerializeField] private Animator _animator;
        
        
        [SerializeField] private float jumpForce;
        [SerializeField] private bool isJump;

        private float _horizontalDirection;
        

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _horizontalMovement = new HorizontalMovement(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);
            _inputReader = new InputReader(GetComponent<PlayerInput>());
            _playerAnims = new PlayerAnims(_animator);
        }

        private void Update()
        {
            _horizontalDirection = _inputReader.HorizontalDirection;

            if (_inputReader.IsJump)
            {
                isJump = true;
                _playerAnims.JumpAnim();
            }

            if (_rigidbody.velocity.y == 0)
            {
                _playerAnims.BackRunAnim();
            }
        }

        private void FixedUpdate()
        {
            _horizontalMovement.Move(_horizontalDirection);

            if (isJump)
            {
                _jumpWithRigidbody.Jump(jumpForce);
            }

            isJump = false;
        }

        private void OnCollisionEnter(Collision collision)
        {
            EnemyController enemyController = collision.gameObject.GetComponent<EnemyController>();
            
            if (enemyController != null)
            {
                GameManager.Instance.StopGame();
            }
        }

        private void OnValidate()
        {
            if (_animator == null)
            {
                _animator = GetComponentInChildren<Animator>();
            }
        }
    }
}
