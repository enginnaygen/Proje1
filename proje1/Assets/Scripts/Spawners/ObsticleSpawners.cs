using System.Collections;
using System.Collections.Generic;
using UdemyProject.Abstract.Spawner;
using UdemyProject.Controller;
using UnityEngine;


namespace UdemyProject.Spawners
{
    public class ObsticleSpawners : BaseSpawner
    {


        [SerializeField] EnemyController[] enemies; // dizi-array





        protected override void Spawn()
        {
            int enemieseRange = Random.Range(0, enemies.Length);
            //Instantiate(enemyTree,transform.position,transform.rotation)=> bu şekilde ayrı şekilde klonlarken alttaki şekilde Scriptin üzerinde bulunan objenin childrenı olarak Spawnlanır.
            Instantiate(enemies[enemieseRange],this.transform);

        }



    }
}
