using _Game.Scripts.Concrates.Controllers;
using UnityEngine;

namespace _Game.Scripts.Concrates.Movement
{
    public class HorizontalMovement
    {
        private PlayerController _playerController;

        public HorizontalMovement(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void Move(float horizontalDirection, float moveSpeed)
        {
            if(horizontalDirection == 0) return;
            
            _playerController.transform.Translate(Vector3.right * (Time.deltaTime * horizontalDirection * moveSpeed));
        }

    }
}
