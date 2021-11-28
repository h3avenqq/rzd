using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RandomLevel : MonoBehaviour
{

    public static void Level()
    {
        int r = Random.Range(1, 3);

        switch (r)
        {
            case 1:
                SceneManager.LoadScene("Scenes/Calls");
                break;
            case 2:
                SceneManager.LoadScene("Scenes/Calls");
                break;
            case 3:
                SceneManager.LoadScene("Scenes/RedLight");
                break;
        }
    }

    public static void Menu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }
}
