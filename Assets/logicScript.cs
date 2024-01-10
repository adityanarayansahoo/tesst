using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;
    public GameObject gameOverscreen;
    public Text FinalScore;
    public AudioSource icePasssound;

    [ContextMenu("Increase Score")]
    public void addScore(int scoretoadd)
    {
    playerScore = playerScore + scoretoadd;
    ScoreText.text = playerScore.ToString();
    FinalScore.text = playerScore.ToString();
        icePasssound.Play();

  }  
  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
  public void GameOver()
  {
     gameOverscreen.SetActive(true);
  }
  public void quitgame()
  {
    Application.Quit();
  }
} 
