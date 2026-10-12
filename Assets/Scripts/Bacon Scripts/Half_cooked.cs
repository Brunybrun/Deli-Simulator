using UnityEngine;

public class Half_cooked : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.baconTimeLeft <= 20f)
        {
            Destroy(gameObject);
        }
    }
}
