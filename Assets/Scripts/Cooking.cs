using UnityEngine;

public class Cooking : MonoBehaviour
{
    public GameObject bacon;
    public GameObject egg;
    public GameObject sandwich;
    public GameObject s_bacon;
    public GameObject s_egg;
    public static bool spawnBacon = true;
    public static bool spawnEgg = true;
    public static int spawnCheese = 0;
    public static bool spawn_s_bacon = false;
    public static bool spawn_s_egg = false;

    void Update()
    {
        //Used to check if the bacon should be spawn in or not
        if (spawnBacon)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
                {
                    //Spawns in a bacon to be cooked
                    //Turns spawnBacon false so that only one piece of bacon can be spawned
                    if (hit.collider.gameObject.tag == "Station")
                    {
                        Vector3 baconSpawn = new Vector3(1.446f, 0.662f, -6.684f);
                        Instantiate(bacon, baconSpawn, Quaternion.identity);
                        spawnBacon = false;
                    }
                }
            }
        }

        if (spawnEgg)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
                {
                    //Spawns in an egg to be cooked
                    //Turns spawnEgg false so that only one piece of egg can be spawned
                    if (hit.collider.gameObject.tag == "Station1")
                    {
                        Vector3 eggSpawn = new Vector3(3.446f, 0.662f, -6.684f);
                        Instantiate(egg, eggSpawn, Quaternion.identity);
                        spawnEgg = false;
                    }
                }
            }
        }

        if (spawnCheese == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(FirstPersonMovement.Eyes.transform.position, FirstPersonMovement.Eyes.transform.forward, out RaycastHit hit, 2))
                {
                    //Spawns in a bacon to be cooked
                    //Turns spawnBacon false so that only one piece of bacon can be spawned
                    if (hit.collider.gameObject.tag == "Station2")
                    {
                        Vector3 sandwichSpawn = new Vector3(4.928f, 0.511f, -7.236f);
                        Instantiate(sandwich, sandwichSpawn, Quaternion.identity);
                        spawnCheese = 0;
                        GameManager.sandwichDone = true;
                    }
                }
            }
        }

        //Once spawnBacon turns false, a timer starts, signifying that the bacon is cooking
        if (spawnBacon == false)
        {
            //I put this extra if statement just so that baconTimeLeft doesn't keep updating once it goes below 0
            if (GameManager.baconTimeLeft > 0)
            {
                GameManager.baconTimeLeft -= Time.deltaTime;
            }
        }

        if (spawnEgg == false)
        {
            //I put this extra if statement just so that baconTimeLeft doesn't keep updating once it goes below 0
            if (GameManager.eggTimeLeft > 0)
            {
                GameManager.eggTimeLeft -= Time.deltaTime;
            }
        }

        if (spawn_s_bacon)
        {
            Vector3 s_baconSpawn = new Vector3(5.066f, 0.56f, -7.089f);
            Instantiate(s_bacon, s_baconSpawn, Quaternion.identity);
            spawn_s_bacon = false;
        }

        if (spawn_s_egg)
        {
            Vector3 s_eggSpawn = new Vector3(4.973f, 0.497f, -7.139f);
            Instantiate(s_egg, s_eggSpawn, Quaternion.identity);
            spawn_s_egg = false;
        }
    }
}
