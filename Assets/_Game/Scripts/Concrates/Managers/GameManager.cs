using System;
using System.Collections;
using _Game.Scripts.Concrates.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Game.Scripts.Concrates.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        public Action OnStop;

        private int _levelDifficultyIndex;

        public int LevelDifficultyIndex
        {
            get => _levelDifficultyIndex;
            set
            { 
                _levelDifficultyIndex = value;
            }
        }

        public void StopGame()
        {
            OnStop?.Invoke();
            Time.timeScale = 0;
        }

        public void LoadScene(string sceneManager)
        {
            StartCoroutine(LoadSceneAsync(sceneManager));
        }

        private IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()
        {
            Debug.Log("Exit Game");
            Application.Quit();
        }
    }
}
