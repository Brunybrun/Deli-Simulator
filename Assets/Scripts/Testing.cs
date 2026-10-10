using UnityEngine;

public class Testing : MonoBehaviour
{
    public float speed = 2;
    public static int inUse = 1;
    public static Vector3 target = GameManager.target1;
    private float timer = GameManager.timeLength;
    public static bool move = true;
    // Vector3 target = new Vector3(0, 0, 6);

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            Vector3 pos = transform.position;
            pos = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            transform.position = pos;
        }
        else if (move == false)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                move = true;
                timer = GameManager.timeLength;
            }
        }
    }
}
