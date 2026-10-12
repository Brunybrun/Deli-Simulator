using UnityEngine;

public class Cooked : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 11f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
            {
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.collider.gameObject.tag == "Cooked")
                {
                    Destroy(transform.parent.gameObject);
                }
            }
        }
    }
}
