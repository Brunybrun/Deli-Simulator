using UnityEngine;

public class Selling : MonoBehaviour
{
    public GameObject[] item;
    public float itemTimer = 3f;
    private bool go;

    void Start()
    {
        
    }

    void Update()
    {
        
        itemTimer -= Time.deltaTime;
        if(itemTimer <= 0)
        {
            int x1 = Random.Range(0, item.Length);
            Vector3 randomItemSpawn1 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
            int x2 = Random.Range(0, item.Length);
            Vector3 randomItemSpawn2 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
            int x3 = Random.Range(0, item.Length);
            Vector3 randomItemSpawn3 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
            Instantiate(item[x1], randomItemSpawn1, Quaternion.identity);
            Instantiate(item[x2], randomItemSpawn2, Quaternion.identity);
            Instantiate(item[x3], randomItemSpawn3, Quaternion.identity);
        }
    }
}
