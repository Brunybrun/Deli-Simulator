using UnityEngine;

public class Item1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                if (hit.collider.gameObject.tag == "Item1")
                {
                    Destroy(gameObject);
                    Selling.checkedItems++;
                }
            }
        }
        else if (Selling.customerSpawn == true)
        {
            Destroy(gameObject);
            Selling.go = true;
            Selling.checkedItems = 0;
        }
    }
}
