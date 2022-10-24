using System;
using _Game.Scripts.Concrates.Movement;
using UnityEngine;

namespace _Game.Scripts.Concrates.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private HorizontalMovement _horizontalMovement;
        private JumpWithRigidbody _jumpWithRigidbody;

        [SerializeField] private float moveSpeed;
        [SerializeField] [Range(-1, 1)] private float horizontalDirection;

        [SerializeField] private float jumpForce;
        [SerializeField] private bool isJump;
        private void Awake()
        {
            _horizontalMovement = new HorizontalMovement(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);
        }

        private void FixedUpdate()
        {
            _horizontalMovement.Move(horizontalDirection, moveSpeed);

            if (isJump)
            {
                _jumpWithRigidbody.Jump(jumpForce);
            }

            isJump = false;
        }
    }
}
