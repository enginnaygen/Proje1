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
            //Instantiate(enemyTree,transform.position,transform.rotation)=> bu �ekilde ayr� �ekilde klonlarken alttaki �ekilde Scriptin �zerinde bulunan objenin children� olarak Spawnlan�r.
            Instantiate(enemies[enemieseRange],this.transform);

        }



    }
}
