using UnityEngine;

public class Customer0 : MonoBehaviour
{
    void Update()
    {
        if (Selling.changeCustomer)
        {
            Destroy(gameObject);
            Selling.changeCustomer = false;
        }
        else if (Selling.customerSpawn == true)
        {
            Destroy(gameObject);
            Selling.go = true;
            Selling.checkedItems = 0;
            Selling.changeCustomer = false;
        }
    }
}
