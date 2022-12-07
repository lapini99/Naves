using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
    public Button restart;
    public Button exit;

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
