using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    bool _isDead;
    public bool IsDead => _isDead;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isDead = true;
        if(_isDead)
        {
            Time.timeScale = 0f;
        }
        Panel.SetActive(true);
    }


}
