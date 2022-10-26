using _Game.Scripts.Abstracts.Controllers;
using _Game.Scripts.Abstracts.Movements;
using _Game.Scripts.Concrates.Controllers;
using UnityEngine;

namespace _Game.Scripts.Concrates.Movement
{
    public class HorizontalMovement : IMover
    {
        private IEntityController _entityController;
        private float _xClamp;
        private float _moveSpeed;

        public HorizontalMovement(IEntityController entityController)
        {
            _entityController = entityController;
            _xClamp = _entityController.XClamp;
            _moveSpeed = _entityController.MoveSpeed;
        }

        public void Move(float horizontalDirection)
        {
            if(horizontalDirection == 0) return;
            
            _entityController.transform.Translate(Vector3.right * (Time.deltaTime * horizontalDirection * _moveSpeed));

            float playerX = Mathf.Clamp(_entityController.transform.position.x, -_xClamp, _xClamp);

            _entityController.transform.position = new Vector3(playerX, _entityController.transform.position.y, 0);
        }

    }
}
