using UnityEngine;

public class item9 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                if (hit.collider.gameObject.tag == "Item9")
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
