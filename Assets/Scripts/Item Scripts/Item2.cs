using UnityEngine;

public class Item2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                if (hit.collider.gameObject.tag == "Item2")
                {
                    Destroy(gameObject);
                    Selling.checkedItems++;
                }
            }
        }
    }
}
