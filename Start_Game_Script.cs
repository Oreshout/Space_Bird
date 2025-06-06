using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchGame()
    {
        SceneManager.LoadScene("Game");
        SceneManager.LoadScene("Game", LoadSceneMode.Additive);
        Debug.Log("Game Started");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Game"));
    }
}
