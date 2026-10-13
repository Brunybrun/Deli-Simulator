using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    //Variables used in other scripts
    public static int playerSpeed = 3;
    public static int AiSpeed = 2;
    public static float timeLength = 2f;
    public static bool move = true;
    public static float baconTimer = 30f;
    public static float baconTimeLeft = baconTimer;
    public static float eggTimer = 30f;
    public static float eggTimeLeft = eggTimer;
    public static bool sandwichDone = false;
    public static Vector3 target1 = new Vector3(10, 0.5f, 6);
    public static Vector3 target2 = new Vector3(2, 0.5f, 2);
    public static Vector3 target3 = new Vector3(5, 0.5f, -3);
    public static int sandwichesDone = 0;
    [SerializeField] TextMeshProUGUI sandwichNum;

    void Update()
    {
        sandwichNum.text = sandwichesDone.ToString();
    }
}
