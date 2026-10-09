using UnityEngine;

public class AiMovement : MonoBehaviour
{
    Rigidbody RB;
    private int Speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(0, RB.linearVelocity.y, 0);
        vel += transform.forward * Speed;
        RB.linearVelocity = vel;
    }
}
