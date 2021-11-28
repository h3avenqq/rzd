using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //GUI
    public GameObject loseScreen;
    public Image timerBar;
    
    public int isLost = 0;
    public float timer = 10f;
    public int timerMax = 10;

    void Start()
    {
        timerBar.gameObject.SetActive(true);
        loseScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        TimerDecrease();
        Win();
        Lose();
    }
    
    void Lose()
    {
        if (isLost == 1)
        {
            Time.timeScale = 0;
            loseScreen.gameObject.SetActive(true);
        }
    }

    void Win()
    {
        if ((isLost == 0) && (timer <= 0))
        {
            // Debug.Log("Win!!!");
            Time.timeScale = 0;
            SceneManager.LoadScene(NextGame());
        }
    }

    void TimerDecrease()
    {
        timer -= Time.deltaTime;
        timerBar.fillAmount = timer / timerMax;
    }
    
    int NextGame()
    { 
        int gameNumber = Random.Range(2, 3);
        switch (gameNumber)
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