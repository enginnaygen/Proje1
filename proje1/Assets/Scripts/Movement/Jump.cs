using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyProject.Movements
{
    public class Jump : MonoBehaviour
    {

        [SerializeField] float jumpForce = 10f; //snake case olarak yazmamamýzýn sebebi, _jumpForce olmamasýnýn sebebi eriþilebilir bir deðiþken olmasýdýr private deðiþken olsaydý _jumpForce þeklinde yazardýk

        public void Ziplama(Rigidbody2D rb2D)
        {
            rb2D.velocity = Vector2.zero;
            rb2D.velocity = new Vector2(0, jumpForce);
        }
    }
}

