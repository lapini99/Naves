using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    Enemy enemyScript;
    public GameObject enemy;

    void Start()
    {
        //gameManagerScript = gameManager.GetComponent<GameManager>();
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyScript = other.GetComponent<Enemy>();
            enemyScript.Health(damage);
            Destroy(gameObject);
        }
    }

}
