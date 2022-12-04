using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float health;
    public int damage;
    public float speed;
    Player playerScript;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
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
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerScript.Health(damage);
            Destroy(gameObject);
        }
    }

    private void AutoDestroy()
    {
        if(transform.localPosition.z == -10)
        {
            playerScript.Health(damage);
            Destroy(gameObject);
            Debug.Log("Meteorito Destruido");
        }
    }
}
