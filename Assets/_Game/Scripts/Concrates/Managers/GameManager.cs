using _Game.Scripts.Concrates.Utilities;
using UnityEngine;

namespace _Game.Scripts.Concrates.Managers
{
    public class GameManager : Singleton<GameManager>
    {

        public void StopGame()
        {
            Time.timeScale = 0;
        }

        public void NextLoadScene()
        {
            Debug.Log("Next Level");
            
        }

        public void ExitGame()
        {
            Debug.Log("Exit Game");
            Application.Quit();
        }
    }
}
