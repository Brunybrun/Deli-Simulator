using UnityEngine;

public class CookTest : MonoBehaviour
{
    LayerMask invisible_Layer_Mask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        invisible_Layer_Mask = LayerMask.NameToLayer("Invisible_Layer");
        invisible_Layer_Mask = ~invisible_Layer_Mask;
        Camera.main.cullingMask = 1 << invisible_Layer_Mask;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
