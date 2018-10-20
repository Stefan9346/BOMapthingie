using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{

    public GameObject redCircle;
    public Transform[] spawnSpots;
    public float startTimeBetweenSpawns;
    public float lifetime = 0.9f;




    private float timeBetweenSpawns;
    private float timeBetweenSpawns2;


    public void Start()
    {
        timeBetweenSpawns = startTimeBetweenSpawns;
    }


    public void Update()
    {
        if (timeBetweenSpawns <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length);
            Instantiate(redCircle, spawnSpots[randPos].position, Quaternion.identity);
            timeBetweenSpawns = 2f;
        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }
    }

}
