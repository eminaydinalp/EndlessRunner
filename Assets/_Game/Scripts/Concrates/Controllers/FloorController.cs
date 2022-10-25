using System;
using UnityEngine;

namespace _Game.Scripts.Concrates.Controllers
{
    public class FloorController : MonoBehaviour
    {
        [Range(0.5f, 2)] [SerializeField] private float moveSpeed;

        private Material _material;

        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;
        }

        private void Update()
        {
            _material.mainTextureOffset += Vector2.down * (moveSpeed * Time.deltaTime);
        }
    }
}
