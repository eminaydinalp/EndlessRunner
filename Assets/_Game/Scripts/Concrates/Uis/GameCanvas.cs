using System;
using _Game.Scripts.Concrates.Managers;
using UnityEngine;

namespace _Game.Scripts.Concrates.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] private GameOverPanel gameOverPanel;

        private void Awake()
        {
            gameOverPanel.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnStop += OpenGameOverPanel;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnStop -= OpenGameOverPanel;
        }

        private void OpenGameOverPanel()
        {
            gameOverPanel.gameObject.SetActive(true);
        }
    }
}
