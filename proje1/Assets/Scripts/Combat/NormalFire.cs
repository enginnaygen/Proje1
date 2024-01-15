using System.Collections;
using System.Collections.Generic;
using UdemyProject.Controller;
using UnityEngine;


namespace UdemyProject.Combat
{
    public class NormalFire : MonoBehaviour
    {
        [SerializeField] FireBallController firstFireBall;
        [SerializeField] Transform firstFireBallTransform;
        [SerializeField] float fireBallDelay = 1f;
        float _fireBallCurrentDelay = 0f;
        bool _fireBallEnabled=false;

        private void Update()
        {
            _fireBallCurrentDelay += Time.deltaTime;

            if (_fireBallCurrentDelay > fireBallDelay )
            {
                _fireBallEnabled = true;
                _fireBallCurrentDelay = 0f;

            }
        }
        public void Atesleme()
        {
            if (_fireBallEnabled)
            {
              Instantiate(firstFireBall, firstFireBallTransform.position, firstFireBallTransform.rotation);
                _fireBallEnabled=false;

            }
        }
    }

}
