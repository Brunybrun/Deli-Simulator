using UnityEngine;

public class DetectTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Point" /*&& transform.position.z >= 3*/)
        {
            GameManager.AiSpeed = GameManager.AiSpeed * -1;
            GameManager.move = false;
        }
        /*else if(collision.gameObject.tag == "Point" && transform.position.z <= 0)
        {
            GameManager.AiSpeed = 2;
        }*/
    }
}
