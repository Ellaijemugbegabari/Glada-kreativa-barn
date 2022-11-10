using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject enemy;

    float timer;

    [SerializeField, Range(1, 10)] //Spawnrate till fiender - Adam
    float spawnRateSec;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRateSec) //Justera spawnraten själv - Adam
        {
            Instantiate(enemy, transform.position, enemy.transform.rotation);
            timer = 0;
        }
    }
}
