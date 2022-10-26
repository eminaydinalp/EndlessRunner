using UnityEngine;

namespace _Game.Scripts.Abstracts.Controllers
{
    public interface IEntityController
    { 
        Transform transform { get; }
        
        Rigidbody Rigidbody { get; }

        float MoveSpeed { get; }
        float XClamp { get; }
        //Rigidbody rigidbody { get; }
    }
}
