using UnityEngine;

public class Burned : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.collider.gameObject.tag == "Burned")
                {
                    Destroy(transform.parent.gameObject);
                    GameManager.baconTimeLeft = GameManager.baconTimer;
                    Cooking.spawnBacon = true;
                }
            }
        }
    }
}
