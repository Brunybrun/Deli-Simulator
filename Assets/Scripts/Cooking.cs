using UnityEngine;

public class Cooking : MonoBehaviour
{
    public GameObject bacon;
    public GameObject egg;
    public static bool spawnBacon = true;
    public static bool spawnEgg = true;
    void Start()
    {

    }

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
                    //Spawns in a bacon to be cooked
                    //Turns spawnBacon false so that only one piece of bacon can be spawned
                    if (hit.collider.gameObject.tag == "Station1")
                    {
                        Vector3 eggSpawn = new Vector3(3.446f, 0.662f, -6.684f);
                        Instantiate(egg, eggSpawn, Quaternion.identity);
                        spawnEgg = false;
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
                Debug.Log(GameManager.baconTimeLeft);
            }
        }

        if (spawnEgg == false)
        {
            //I put this extra if statement just so that baconTimeLeft doesn't keep updating once it goes below 0
            if (GameManager.eggTimeLeft > 0)
            {
                GameManager.eggTimeLeft -= Time.deltaTime;
                Debug.Log(GameManager.eggTimeLeft);
            }
        }
    }
}
