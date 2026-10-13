using UnityEngine;

public class SanCooked : MonoBehaviour
{
    void Update()
    {
        if(GameManager.sandwichDone)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
