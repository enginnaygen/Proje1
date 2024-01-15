using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorGosterme : MonoBehaviour
{
    Text _skorTexti;

    private void Awake()
    {
        _skorTexti = GetComponent<Text>();
    }
    private void Start()
    {
        GameManager.Instance.ScoreChange += SkorDegisme;
    }

    private void OnDisable()
    {
        GameManager.Instance.ScoreChange-= SkorDegisme; 
    }
    public void SkorDegisme(int skor)
    {
        _skorTexti.text = skor.ToString();
    }
}
