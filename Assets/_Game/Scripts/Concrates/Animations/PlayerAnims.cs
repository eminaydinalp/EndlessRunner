using _Game.Scripts.Concrates.Utilities;
using UnityEngine;

namespace _Game.Scripts.Concrates.Animations
{
    public class PlayerAnims
    {
        private Animator _animator;

        public PlayerAnims(Animator animator)
        {
            _animator = animator;
        }
    
        public void JumpAnim()
        {
            _animator.SetBool(Consts.JumpAnim, true);
        }

        public void BackRunAnim()
        {
            _animator.SetBool(Consts.JumpAnim, false);
        }
        
    }
}
