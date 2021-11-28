using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreenControls : MonoBehaviour
{
    public void ReplayPressed()
    {
        SceneManager.LoadScene(RandomGame());
    }
    
    public void BackToMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    int RandomGame()
    { 
        int gameNumber = Random.Range(1, 3);
        switch (gameNumber)
        {
            case 1:
                return 1;
            case 2:
                return 2;
            case 3:
                return 3;
            default:
                return 0;
        }
    }
}