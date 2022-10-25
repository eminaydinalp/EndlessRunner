using System;
using _Game.Scripts.Abstracts;
using _Game.Scripts.Concrates.Inputs;
using _Game.Scripts.Concrates.Movement;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Game.Scripts.Concrates.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private HorizontalMovement _horizontalMovement;
        private JumpWithRigidbody _jumpWithRigidbody;
        private IInputReader _inputReader;

        [SerializeField] private float moveSpeed;
        [SerializeField] private float horizontalMoveXClamp;

        [SerializeField] private float jumpForce;
        [SerializeField] private bool isJump;

        private float _horizontalDirection;
        private void Awake()
        {
            _horizontalMovement = new HorizontalMovement(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);
            _inputReader = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            _horizontalDirection = _inputReader.HorizontalDirection;

            if (_inputReader.IsJump)
            {
                isJump = true;
            }

            Debug.Log("Jump : " + _inputReader.IsJump);
        }

        private void FixedUpdate()
        {
            _horizontalMovement.Move(_horizontalDirection, moveSpeed, horizontalMoveXClamp);

            if (isJump)
            {
                _jumpWithRigidbody.Jump(jumpForce);
            }

            isJump = false;
        }
    }
}
