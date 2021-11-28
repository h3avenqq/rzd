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
        Time.timeScale = 1;
        timerBar.gameObject.SetActive(true);
        // loseScreen.gameObject.SetActive(false);
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
            RandomLevel.Menu();
            // loseScreen.gameObject.SetActive(true);
        }
    }

    void Win()
    {
        if ((isLost == 0) && (timer <= 0))
        {
            Time.timeScale = 0;
            RandomLevel.Menu();
            // SceneManager.LoadScene(NextGame());
        }
    }

    void TimerDecrease()
    {
        timer -= Time.deltaTime;
        timerBar.fillAmount = timer / timerMax;
    }
    
}