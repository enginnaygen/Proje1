using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace UdemyProject.Controller
{
    public class FireBallController : LifeCycleController
    {
      

        private void OnTriggerEnter2D(Collider2D collision)
        {
            /*Debug.Log(collision.name);
            if (collision.tag == "RedDragon")
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);

            }*/
            EnemyController enemy = collision.GetComponent<EnemyController>();

           if (enemy != null)
           {
               Destroy(enemy.gameObject);
               Destroy(this.gameObject);
               GameManager.Instance.IncreaseScore();
                
           }

        }
       
    }
}
           
    

