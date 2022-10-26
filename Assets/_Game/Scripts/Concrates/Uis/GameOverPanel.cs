using _Game.Scripts.Concrates.Managers;
using _Game.Scripts.Concrates.Utilities;
using UnityEngine;

namespace _Game.Scripts.Concrates.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void ReplyButton()
        {
            GameManager.Instance.LoadScene(Consts.GameScene);
        }

        public void GoBackMenuButton()
        {
            GameManager.Instance.LoadScene(Consts.MenuScene);
        }
    
    }
}
