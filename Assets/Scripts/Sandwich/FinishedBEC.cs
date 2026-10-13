using UnityEngine;

public class FinishedBEC : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                Debug.Log(hit.collider.transform.parent.gameObject.tag);
                if (hit.collider.transform.parent.gameObject.tag == "Sandwich")
                {
                    GameManager.sandwichDone = false;
                    Cooking.spawnUnfinSandwich = true;
                    GameManager.sandwichesDone++;
                    GameManager.moneyMade += 6;
                    Destroy(gameObject);
                }
            }
        }
    }
}
