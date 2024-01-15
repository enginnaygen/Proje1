using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentObject : MonoBehaviour
{
    [SerializeField] GameObject PersistentObjectt;
    static bool _ilkOlusum = true;

    private void Start()
    {
        if( _ilkOlusum )
        {
            SpawnPersistentObject();
            _ilkOlusum = false;
        }
    }

    private void SpawnPersistentObject()
    {
        GameObject newPersistentObject = Instantiate( PersistentObjectt );
        DontDestroyOnLoad( newPersistentObject );

    }
}
