using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameControl : MonoBehaviour
{
    public float timerMax = 5;//надо будет задавать в старте исходя из сложности этапа
    private float timer;
    private float xPos; //142 214
    private float zPos; //180 -12
   
    private static int countPers = 10;

    private bool exist = false;

    public GameObject pers;
    private GameObject[] allPers = new GameObject[countPers];

    public Image timeBar;

    private void Start()
    {
        timer = timerMax;
        for (int i = 0; i < countPers; i++)
        {
            xPos = Random.Range(142f, 214f);
            zPos = Random.Range(-12f, 180f);
            allPers[i] = Instantiate(pers, new Vector3(xPos, 16, zPos), Quaternion.identity);
        }
    }

    void Update()
    {
        exist = false;
        timer -= Time.deltaTime;
        timeBar.fillAmount = timer / timerMax;
        foreach (var p in allPers)
        {
            if (p.GetComponent<Person>().isCall)
            {
                exist = true;
            }
        }

        if (!exist)
        {
            Time.timeScale = 0;
            Debug.Log("WIN");
        }
        else if (timer<=0)
        {
            Time.timeScale = 0;
            Debug.Log("LOSE");
        }
    }
}
// if (p.GetComponent<Person>().isCall)
// {
//     //win
//     Debug.Log("WIN");
// }
// else if (timer <= 0)
// {
//     Debug.Log("LOSE");
//     //lose
// }