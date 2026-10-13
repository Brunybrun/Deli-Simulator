using UnityEngine;

public class EggFried : MonoBehaviour
{
    void Update()
    {
        if (GameManager.eggTimeLeft <= 0)
        {
            Destroy(gameObject);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.collider.transform.parent.gameObject.tag == "Cooked")
                {
                    Destroy(transform.parent.gameObject);
                    GameManager.eggTimeLeft = GameManager.eggTimer;
                    Cooking.spawnEgg = true;
                    Cooking.spawn_s_egg = true;
                }
            }
        }
    }
}
