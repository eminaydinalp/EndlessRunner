using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Game.Scripts.Concrates.Managers
{
    public class GameManager : Utilities.Singleton<GameManager>
    {
        public Action OnStop;
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
