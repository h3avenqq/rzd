using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}