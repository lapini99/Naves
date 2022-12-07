using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    private int score = 1;
    public float health;
    public int damage;
    public float speed;
    Player playerScript;
    private GameObject player;

    GameManager gameManagerScript;
    public GameObject gameManager;

    void Start()
    {
        gameManagerScript = gameManager.GetComponent<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player>();
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        Destroy(gameObject, 10);
        AutoDestroy();
    }

    public void Health(int value)
    {
        health -= value;

        if (health <= 0)
        {
            playerScript.TotalScore(score);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            playerScript.Health(damage);
            Destroy(gameObject);
        }
    }

    private void AutoDestroy()
    {
        if(transform.localPosition.z == -10)
        {
            Debug.Log("Meteorito Destruido");
            playerScript.Health(damage);
            Destroy(gameObject);
        }
    }
}
