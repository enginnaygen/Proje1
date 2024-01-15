using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeCycleController : MonoBehaviour
{
    [SerializeField] float _yasamSuresi = 5f;
    float _gecenZaman;

    private void Update()
    {
        _gecenZaman += Time.deltaTime;

        if (_gecenZaman > _yasamSuresi)
        {
            Destroy(this.gameObject);
        }
    }
}
