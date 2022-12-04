using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string level;
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public GameObject creditsPanel;

    private void Start()
    {
        mainPanel.SetActive(true);
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitDesktop()
    {
        Debug.Log("Salir al escritorio");
        Application.Quit();
    }

    public void LoadLevel(int value)
    {
        level = "Level" + value;
        SceneManager.LoadScene(level);
    }

    public void OptionsPanel()
    {
        optionsPanel.SetActive(true);
    }

    public void CredtisPanel()
    {
        creditsPanel.SetActive(true);
    }

    public void Return()
    {
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

}
