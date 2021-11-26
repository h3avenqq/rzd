using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public GameController GameController;

    void OnTriggerEnter(Collider collider)
    {
        if (GameController.isLost != 1)
        {
            GameController.isLost = 1;
            Destroy(collider.gameObject);
        }
    }
}