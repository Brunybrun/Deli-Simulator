using UnityEngine;

public class Selling : MonoBehaviour
{
    public GameObject[] item;
    public static float itemTimer = 1f;
    public float itemTimeLeft = itemTimer;
    private bool go = true;
    public static int checkedItems = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (go)
        {
            itemTimeLeft -= Time.deltaTime;
            if (itemTimeLeft <= 0)
            {
                int x1 = Random.Range(0, item.Length);
                Vector3 randomItemSpawn1 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
                int x2 = Random.Range(0, item.Length);
                if (x1 == x2)
                {

                }
                Vector3 randomItemSpawn2 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
                int x3 = Random.Range(0, item.Length);
                Vector3 randomItemSpawn3 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
                Instantiate(item[x1], randomItemSpawn1, Quaternion.identity);
                Instantiate(item[x2], randomItemSpawn2, Quaternion.identity);
                Instantiate(item[x3], randomItemSpawn3, Quaternion.identity);
                itemTimeLeft = 1f;
                go = false;
            }
        }

        if(checkedItems == 3)
        {
            go = true;
            checkedItems = 0;
        }
    }
}
