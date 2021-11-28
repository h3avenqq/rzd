using UnityEngine;

public class SpawnPeople : MonoBehaviour
{
    public GameObject person;
    public int peopleAmount = 3;

    float y = 6.5f;
    private float z;

    void Start()
    {
        RandomSpawn();
    }

    void RandomSpawn()
    {
        for (int i = 1; i <= peopleAmount; i++)
        {
            float x = Random.Range(-50f, 20f);
            switch (i)
            {
                case 1:
                    z = Random.Range(105f, 160f);
                    break;
                case 2:
                    z = Random.Range(50f, 100f);
                    break;
                case 3:
                    z = Random.Range(0f, 45f);
                    break;
                default:
                    z = Random.Range(-5f, 150f);
                    break;
            }

            Vector3 pos = new Vector3(x, -6.5f, z);
            GameObject gm = Instantiate(person, pos, Quaternion.Euler(0,-90f,0));
        }
    }
}