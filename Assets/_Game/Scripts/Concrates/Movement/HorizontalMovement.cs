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

        public void Move(float horizontalDirection, float moveSpeed, float xClamp)
        {
            if(horizontalDirection == 0) return;
            
            _playerController.transform.Translate(Vector3.right * (Time.deltaTime * horizontalDirection * moveSpeed));

            float playerX = Mathf.Clamp(_playerController.transform.position.x, -xClamp, xClamp);

            _playerController.transform.position = new Vector3(playerX, _playerController.transform.position.y, 0);
        }

    }
}
