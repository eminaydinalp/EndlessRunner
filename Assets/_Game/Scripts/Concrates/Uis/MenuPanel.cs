using _Game.Scripts.Concrates.Managers;
using _Game.Scripts.Concrates.Utilities;
using UnityEngine;

namespace _Game.Scripts.Concrates.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButton()
        {
            GameManager.Instance.LoadScene(Consts.GameScene);
        }

        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }
    
    }
}
