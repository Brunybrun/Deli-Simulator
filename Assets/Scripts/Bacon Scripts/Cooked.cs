using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Cooked : MonoBehaviour
{
    void Update()
    {
        if (GameManager.baconTimeLeft <= 0)
        {
            Destroy(gameObject);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.collider.gameObject.tag == "Cooked")
                {
                    Destroy(transform.parent.gameObject);
                    GameManager.baconTimeLeft = GameManager.baconTimer;
                    Cooking.spawnBacon = true;
                    Cooking.spawn_s_bacon = true;
                }
            }
        }
    }
}
