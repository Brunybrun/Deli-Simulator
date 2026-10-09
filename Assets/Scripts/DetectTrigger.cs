using UnityEngine;

public class DetectTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Point" && transform.position.z >= 3)
        {
            GameManager.AiSpeed = -2;
        }else if(collision.gameObject.tag == "Point" && transform.position.z <= 0)
        {
            GameManager.AiSpeed = 2;
        }
    }
}
