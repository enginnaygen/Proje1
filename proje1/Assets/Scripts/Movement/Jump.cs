using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyProject.Movements
{
    public class Jump : MonoBehaviour
    {

        [SerializeField] float jumpForce = 10f; //snake case olarak yazmamam�z�n sebebi, _jumpForce olmamas�n�n sebebi eri�ilebilir bir de�i�ken olmas�d�r private de�i�ken olsayd� _jumpForce �eklinde yazard�k

        public void Ziplama(Rigidbody2D rb2D)
        {
            rb2D.velocity = Vector2.zero;
            rb2D.velocity = new Vector2(0, jumpForce);
        }
    }
}

