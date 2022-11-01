using _Game.Scripts.Abstracts.Controllers;
using _Game.Scripts.Concrates.Managers;
using _Game.Scripts.Concrates.Utilities;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Game.Scripts.Concrates.Controllers
{
    public class EnemySpawnerController : SpawnerController
    {
        protected override void Spawn()
        {
            base.Spawn();
            int index = Random.Range(0, EnemyManager.Instance.EnemyIndex);
            EnemyManager.Instance.SpawnFromPool(EnemyManager.Instance.pools[index].type, transform.position, transform.rotation);
        }

    }
}
