using UnityEngine;

public class item8 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                if (hit.collider.transform.parent.gameObject.tag == "Item8")
                {
                    Destroy(gameObject);
                    Selling.checkedItems++;
                    GameManager.moneyMade += 0.5f;
                }
            }
        }
        else if (Selling.customerSpawn == true)
        {
            Destroy(gameObject);
            Selling.go = true;
            Selling.checkedItems = 0;
            GameManager.moneyMade -= 1;
        }
    }
}
