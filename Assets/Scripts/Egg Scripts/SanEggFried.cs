using UnityEngine;

public class SanEggFried : MonoBehaviour
{
    void Update()
    {
        if (GameManager.sandwichDone)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
