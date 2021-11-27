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

    int RandomGame()
    { 
        int LineReplayGameNumber = Random.Range(2, 3);
        switch (LineReplayGameNumber)
        {
            case 2:
                return 2;
            case 3:
                return 3;
            default:
                return 0;
        }
    }
}