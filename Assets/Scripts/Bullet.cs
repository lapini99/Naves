using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    Enemy enemyScript;
    public GameObject enemy;

    public int score = 1;
    Player playerScript;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player>();
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyScript = other.GetComponent<Enemy>();
            enemyScript.Health(damage);
            playerScript.TotalScore(score);
            Destroy(gameObject);
        }
    }

}
