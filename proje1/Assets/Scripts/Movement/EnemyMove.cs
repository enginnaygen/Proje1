using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyProject.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyMove : MonoBehaviour
    {
        Rigidbody2D _rb;
        [SerializeField] float hiz = 5;
        

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _rb.velocity = Vector2.left * hiz;
        }
    }

}
