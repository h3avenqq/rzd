using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Menu : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene(RandomGame());
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

    // у меня индексы сцен: 0-MainMenu, 1-Line, 2-RedLight, 3 для calls
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