using _Game.Scripts.Abstracts;
using _Game.Scripts.Concrates.Utilities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Game.Scripts.Concrates.Inputs
{
    public class InputReader : IInputReader
    {
        private PlayerInput _playerInput;

        public float HorizontalDirection { get; private set; }
        public bool IsJump { get; private set; }

        public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;
            
            _playerInput.actions[Consts.HorizontalMove].performed += HorizontalMoveOnperformed;
            _playerInput.actions[Consts.Jump].started += OnJump;
            _playerInput.actions[Consts.Jump].canceled += OnJump;
        }

        private void OnJump(InputAction.CallbackContext obj)
        {
            IsJump = obj.ReadValueAsButton();
        }

        private void HorizontalMoveOnperformed(InputAction.CallbackContext obj)
        {
            HorizontalDirection = obj.ReadValue<float>();
        }
    }
}
