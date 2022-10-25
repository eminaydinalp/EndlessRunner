using _Game.Scripts.Concrates.Managers;
using UnityEngine;

namespace _Game.Scripts.Concrates.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButton()
        {
            GameManager.Instance.NextLoadScene();
        }

        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }
    
    }
}
