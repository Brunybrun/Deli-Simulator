using UnityEngine;

public class UnfinishedBEC : MonoBehaviour
{
    void Update()
    {
        if (GameManager.sandwichDone)
        {
            Destroy(gameObject);
        }
    }
}
