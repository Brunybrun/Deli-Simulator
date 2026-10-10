using UnityEngine;

public class DetectTrigger1 : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            if (Testing.inUse == 1)
            {
                Testing.target = GameManager.target2;
                Testing.inUse = 2;
                Testing.move = false;
            }
            else if (Testing.inUse == 2)
            {
                Testing.target = GameManager.target3;
                Testing.inUse = 3;
                Testing.move = false;
            }
            else if (Testing.inUse == 3)
            {
                Testing.target = GameManager.target1;
                Testing.inUse = 1;
                Testing.move = false;
            }
        }
    }
}
