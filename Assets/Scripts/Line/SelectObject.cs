using UnityEngine;

public class SelectObject : MonoBehaviour
{
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.collider != null)
                {
                    hit.collider.GetComponent<PutBack>().Back();
                }
            }
        }
    }
}