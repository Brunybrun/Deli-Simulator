using UnityEngine;

public class AiMovement : MonoBehaviour
{
    public Rigidbody RB;
    private int Speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(0, RB.linearVelocity.y, 0);
        if (RB.position.z < 10) {
            vel += transform.forward * Speed;
            RB.linearVelocity = vel;
        }
        /*if (RB.position.z > 10)
        {
            vel += transform.forward * Speed;
            RB.linearVelocity = vel;
        }*/
    }
}
