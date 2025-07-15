using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform[] spownPoint;
    public GameObject[] hazards;
    private float timeBtwSpawns;
    public float startTimeBtwSpawn;
    public float minTime;
    public float deficalty;
    public GameObject player;
    void Start()
    {

    }

    void Update()
    {
        if (player != null)
        {
            if (timeBtwSpawns <= 0)
            {
                Transform randomspown = spownPoint[Random.Range(0, spownPoint.Length)];
                GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];
                Instantiate(randomHazard, randomspown.position, Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawn;
                if (startTimeBtwSpawn > minTime)
                {
                    startTimeBtwSpawn -= deficalty;
                }
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }


    }
}
