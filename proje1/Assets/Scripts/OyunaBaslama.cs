using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunaBaslama : MonoBehaviour
{

    /*private void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            Time.timeScale = 1f;
            Debug.Log("Entere Bas�ld�");
            SceneManager.LoadScene(0);

        }
    }*/
    public void Baslama()
    {
        Time.timeScale = 1f;
        //Debug.Log("Entere Bas�ld�");
        SceneManager.LoadScene(1);
    }
    public void C�k�s()
    {
        Application.Quit();
    }
}
