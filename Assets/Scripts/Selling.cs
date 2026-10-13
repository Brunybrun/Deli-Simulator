using UnityEngine;

public class Selling : MonoBehaviour
{
    //Game Objects
    public GameObject[] item;
    public GameObject[] customers;

    //Timers
    public static float itemTimer = 1f;
    public float itemTimeLeft = itemTimer;
    public static float customerTimer = 5f;
    public static float customerTimeLeft = customerTimer;

    //Checks
    public static bool customerSpawn = true;
    public static bool go = true;
    public static int totalItems = 3;
    public static int checkedItems = 0;
    public static bool changeCustomer = false;

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
                //Spawn in a random customer
                int c  = Random.Range(0, customers.Length);
                Vector3 randomCustomerSpawn = new Vector3(12.028f, 0.5f, -2f);
                Instantiate(customers[c], randomCustomerSpawn, Quaternion.identity);

                //Spawn in the random items
                int x1 = Random.Range(0, item.Length);
                Vector3 randomItemSpawn1 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
                int x2 = Random.Range(0, item.Length);
                //The while loops are there so that there's no two of the same item
                while (x1 == x2)
                {
                    x2 = Random.Range(0, item.Length);
                }
                Vector3 randomItemSpawn2 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
                int x3 = Random.Range(0, item.Length);
                while (x1 == x3 || x2 == x3)
                {
                    x3 = Random.Range(0, item.Length);
                }
                Vector3 randomItemSpawn3 = new Vector3(Random.Range(10.6f, 13.3f), 1.075f, Random.Range(-3.749f, -3.222f));
                Instantiate(item[x1], randomItemSpawn1, Quaternion.identity);
                Instantiate(item[x2], randomItemSpawn2, Quaternion.identity);
                Instantiate(item[x3], randomItemSpawn3, Quaternion.identity);

                itemTimeLeft = 1f;
                customerSpawn = false;
                go = false;
            }
        }

        if (customerSpawn == false)
        {
            //I put this extra if statement just so that customerTimeLeft doesn't keep updating once it goes below 0
            if (customerTimeLeft > 0)
            {
                customerTimeLeft -= Time.deltaTime;
            }
        }

        //If items were able to be checked in time, gain money
        if (checkedItems == totalItems)
        {
            go = true;
            checkedItems = 0;
            changeCustomer = true;
            customerSpawn = true;
            Selling.customerTimeLeft = Selling.customerTimer;
        }
        
        //If customer waited too long, lose money
        if (customerTimeLeft <= 0)
        {
            customerSpawn = true;
            Selling.customerTimeLeft = Selling.customerTimer;
        }
    }
}
