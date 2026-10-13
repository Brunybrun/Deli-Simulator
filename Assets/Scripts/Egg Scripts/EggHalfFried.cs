using UnityEngine;

public class EggHalfFried : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.eggTimeLeft <= 10f)
        {
            Destroy(gameObject);
        }
    }
}
