using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    Rigidbody RB;
    public int Speed = 3;
    public static Camera Eyes;
    public float MSensitivity = 1;
    Ray ray;

    void Start()
    {
        Eyes = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Camera Controls
        Vector2 mouse = Mouse.current.delta.ReadValue();
        transform.Rotate(0, mouse.x * MSensitivity, 0);
        Eyes.transform.Rotate(mouse.y * MSensitivity * -1, 0, 0);

        //Keyboard controls
        Vector3 vel = new Vector3(0, RB.linearVelocity.y, 0);
        if (Keyboard.current.wKey.isPressed)
            vel += transform.forward * Speed;
        if (Keyboard.current.sKey.isPressed)
            vel += transform.forward * -Speed;
        if (Keyboard.current.dKey.isPressed)
            vel += transform.right * Speed;
        if (Keyboard.current.aKey.isPressed)
            vel += transform.right * -Speed;
        if (Keyboard.current.wKey.isPressed && Keyboard.current.shiftKey.isPressed)
            vel += transform.forward * (Speed+1);
        RB.linearVelocity = vel;

    }
}
