using UnityEngine;

public class DetectTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ai")
        {
            GameManager.AiSpeed = -2;
            Debug.Log(collision.gameObject.tag);
        }
    }
}
