using System;
using UnityEngine;

namespace _Game.Scripts.Example
{
    public class OnValidateExample : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        
        private void OnValidate()
        {
            if (_rigidbody == null)
            {
                _rigidbody = GetComponent<Rigidbody>();
            }
        }
        
        
    }
}
