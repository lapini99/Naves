using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public float start;
    public float delay;

    public float randomX;
    public float randomY;

    void Start()
    {
        InvokeRepeating("CreateEnemies", start, delay);
    }

    void CreateEnemies()
    {
        randomX = Random.Range(-7f, 7f);
        randomY = Random.Range(-4f, 4f);

        Instantiate(enemy, new Vector3(randomX, randomY, transform.localPosition.z), enemy.transform.rotation);
    }
}
