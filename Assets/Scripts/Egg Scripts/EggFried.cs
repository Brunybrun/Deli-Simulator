using UnityEngine;

public class EggFried : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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
                }
            }
        }
    }
}
