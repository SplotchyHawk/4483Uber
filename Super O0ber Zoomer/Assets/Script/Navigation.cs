using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform Person;
    public static bool spawned = true;

    void SpawnBlocks()
    {
        int random = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (random == i)
            {
                Person.position = spawnPoints[i].position;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (spawned == false)
        {
            SpawnBlocks();
            spawned = true;
        }
    }
}
