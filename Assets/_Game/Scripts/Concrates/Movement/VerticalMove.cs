using _Game.Scripts.Abstracts.Controllers;
using _Game.Scripts.Abstracts.Movements;
using _Game.Scripts.Concrates.Controllers;
using UnityEngine;

namespace _Game.Scripts.Concrates.Movement
{
    public class VerticalMove : IMover
    {
        private IEntityController _entityController;
        private float _moveSpeed;

        public VerticalMove(IEntityController entityController)
        {
            _entityController = entityController;
            _moveSpeed = _entityController.MoveSpeed;
        }

        public void Move(float direction = 1)
        {
            _entityController.transform.Translate(Vector3.back *(direction * Time.deltaTime * _moveSpeed));
        }

    }
}
