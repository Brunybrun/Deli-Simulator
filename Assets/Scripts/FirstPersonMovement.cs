using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    Rigidbody RB;
    public int Speed = 3;
    public Camera Eyes;
    public float MSensitivity = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Mouse.current.delta.ReadValue();
        transform.Rotate(0, mouse.x * MSensitivity, 0);
        Eyes.transform.Rotate(mouse.y * MSensitivity * -1, 0, 0);

        Vector3 vel = new Vector3(0, RB.linearVelocity.y, 0);
        if (Keyboard.current.wKey.isPressed)
            vel += transform.forward * Speed;
        if (Keyboard.current.sKey.isPressed)
            vel += transform.forward * -Speed;
        if (Keyboard.current.dKey.isPressed)
            vel += transform.right * Speed;
        if (Keyboard.current.aKey.isPressed)
            vel += transform.right * -Speed;
        RB.linearVelocity = vel;

    }
}
