using System.Collections;
using System.Collections.Generic;
using UdemyProject.Controller;
using UnityEngine;

namespace UdemyProject.Abstract.Spawner
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(1, 5)]
        [SerializeField] float maxSpawnTime;
        [Range(1, 5)]
        [SerializeField] float minSpawnTime;



        float _currentSpawnTime; //þimdiki zaman
        float _timeBoundary; //zaman sýnýrý

        private void Start()
        {
            ResetTimes();
        }

        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                ResetTimes();
            }
        }

        protected abstract void Spawn();
        /*protected virtual void Spawn()
        {

        }*/



        private void ResetTimes()
        {
            _currentSpawnTime = 0;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
