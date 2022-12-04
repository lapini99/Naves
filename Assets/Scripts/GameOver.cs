using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    Player playerScript;
    public GameObject player;
    public GameObject gameOverScreen;

    public Button restart;
    public Button exit;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player>();
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    public void Death()
    {
        if (playerScript.healthPlayer <= 0)
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
        } 

    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
