using UnityEngine;

public class Testing : MonoBehaviour
{
    public float speed = 2;
    public Vector3 target = new Vector3(0, 0, 6);

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
