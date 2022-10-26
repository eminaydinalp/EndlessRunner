using System;
using UnityEngine;

namespace _Game.Scripts.Abstracts.Controllers
{
    public abstract class CharacterController : MonoBehaviour
    {
        protected Rigidbody _rigidbody;

        public Rigidbody Rigidbody => _rigidbody;
        
        [SerializeField] private float moveSpeed;
        public float MoveSpeed => moveSpeed;
        
        [SerializeField] private float horizontalMoveXClamp;
        public float XClamp => horizontalMoveXClamp;
    }
}
