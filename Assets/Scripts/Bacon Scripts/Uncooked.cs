using UnityEngine;

public class Uncooked : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if(GameManager.baconTimeLeft <= 30f)
        {
            Destroy(gameObject);
        }
    }
}
