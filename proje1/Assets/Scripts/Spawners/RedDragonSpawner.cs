using System.Collections;
using System.Collections.Generic;
using UdemyProject.Abstract.Spawner;
using UdemyProject.Controller;
using UnityEngine;

namespace UdemyProject.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        [SerializeField] EnemyController enemy;

        protected override void Spawn()
        {
            Instantiate(enemy,this.transform);
        }

    }
}


