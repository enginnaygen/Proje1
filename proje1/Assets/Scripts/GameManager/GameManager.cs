using System.Collections;
using System.Collections.Generic;
using UdemyProject.Controller;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] int skor;
    public static GameManager Instance {  get; private set; }

   private void Awake()
    {
        SingletonThisGameObject();  
      
    }

    public event System.Action<int> ScoreChange;

   public void IncreaseScore()
    {
        skor++;
        ScoreChange?.Invoke(skor);
    }

    private void SingletonThisGameObject()
    { 
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
      }

    public void RestartGame()
    {
        skor = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);

        //StartCoroutine(RestartGameAysnc());
    }

    
    /*private IEnumerator RestartGameAysnc()
    {
        skor = 0;
        yield return SceneManager.LoadSceneAsync("Game");
    }*/

   

}


