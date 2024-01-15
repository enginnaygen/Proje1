using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UdemyProject.Movements;
using UdemyProject.Controller;
using UdemyProject.Combat;

namespace UdemyProject.Controller
{
    public class PlayerController : MonoBehaviour
    {
        //public float _sagSolHareket;
        //public int _hareket;
        //public float _yukariAsagiHareket;
        Rigidbody2D _rb;
        bool _leftClick;
        Jump _jump;
        InputController _input;
        NormalFire _normalFire;
        AudioSource _audioSource;
        


        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
            _rb = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _normalFire = GetComponent<NormalFire>();
            _input = new InputController();
            
        }
        private void Update()
        {
            //_sagSolHareket = Input.GetAxisRaw("Horizontal");
            //_yukariAsagiHareket = Input.GetAxisRaw("Vertical");
            //_rb.velocity = new Vector2(0, _yukariAsagiHareket*_hareket);

            if (_input.LeftMouseClick)
            {
                Debug.Log("RightMouseClick");
                _leftClick = true;
            }

            if (_input.RightMouseClick)
            {
                _normalFire.Atesleme();
            }



        }

        private void FixedUpdate()
        {
            if (_leftClick)
            {
                _jump.Ziplama(_rb);
                _audioSource.Play();
                //_rb.velocity = Vector2.zero;
                //_rb.velocity = new Vector2(0, _ziplama);
                //_rb.AddForce(new Vector2(0, _ziplama*500));
                _leftClick = false;

            }
            
        }

        /*private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Zemin" || collision.gameObject.tag=="Agac" || collision.gameObject.tag== "RedDragon")
            {
                SceneManager.LoadScene(0);
            }
            GameManager.Instance.RestartGame();
        }*/

       
    }

}
