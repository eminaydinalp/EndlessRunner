using _Game.Scripts.Concrates.Controllers;
using UnityEngine;

namespace _Game.Scripts.Concrates.Movement
{
    public class JumpWithRigidbody
    {
        private Rigidbody _rigidbody;

        public JumpWithRigidbody(PlayerController playerController)
        {
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void Jump(float jumpForce)
        {
            if(_rigidbody.velocity.y != 0) return;
            
            _rigidbody.velocity = Vector3.zero;
            
            _rigidbody.AddForce(Vector3.up * (Time.deltaTime * jumpForce), ForceMode.Impulse);
        }

    }
}
