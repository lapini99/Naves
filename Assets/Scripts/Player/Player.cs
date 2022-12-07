using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public GameObject gameManager;
    GameManager gameManagerScript;

    public bool isBossActive = false;
    public int instantiateBoss = 5;
    public GameObject boss;
    public GameObject[] enemies;

    public int healthPlayer;
    public Image lifeBar;

    public float maxH;
    public float maxV;

    private float h;
    private float v;
    public float maxRot = 30f;

    public int score = 0;

    void Start()
    {
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        transform.localPosition = new Vector3(h * maxH, v * maxV, 0);
        transform.eulerAngles = new Vector3(0, 0, h * maxRot );

        lifeBar.fillAmount = healthPlayer / 50f;

        KillAllEnemies();
    }

    public void Health(int value)
    {
        healthPlayer -= value;

        Debug.Log(healthPlayer);

        if (healthPlayer <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TotalScore(int value)
    {
        score += value;
        gameManagerScript.Score(score);

        if (score >= instantiateBoss && !isBossActive)
        {
            Instantiate(boss, boss.transform.position, boss.transform.rotation);
            isBossActive = true;
        }
    }

    void KillAllEnemies()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (GameObject enemy in enemies)
            {
                Destroy(enemy);
            }
            Debug.Log("Q pressed");
        }
    }
}
