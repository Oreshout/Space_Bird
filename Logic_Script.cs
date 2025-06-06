using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic_Script : MonoBehaviour
{
   public int score;
   public Text scoreText;
   public GameObject gameOverScreen;

   public GameObject gameStartScreen;

    [ContextMenu("Add score")]
   public void add_score(int scoretoadd)
   {
        score = score + scoretoadd;
        Debug.Log("Score: " + score);
        scoreText.text = score.ToString();
   }

   public void restartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void gameOver()
   {
      gameOverScreen.SetActive(true);
   }

   public void quitGame()
   {
      Application.Quit();
      Debug.Log("Quit Game");
   }

   public void Start()
   {
      gameStartScreen.SetActive(true);
   }

   public void LunchGame()
   {
        SceneManager.LoadScene("Start");
        Debug.Log("Game Started");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Game"));

    }

}
