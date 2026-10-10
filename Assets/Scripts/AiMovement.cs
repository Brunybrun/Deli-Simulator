using UnityEngine;

public class AiMovement : MonoBehaviour
{
    Rigidbody RB;
    private float timer = GameManager.timeLength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.move == true)
        {
            Vector3 vel = new Vector3(0, RB.linearVelocity.y, 0);
            vel += transform.forward * GameManager.AiSpeed;
            RB.linearVelocity = vel;
        }
        else if (GameManager.move == false) {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                GameManager.move = true;
                timer = GameManager.timeLength;
            }
        }
    }
}
