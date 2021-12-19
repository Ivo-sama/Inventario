using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Detection : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused;
    public GameObject optMenu;
    public void startGame()
    {
        SceneManager.LoadScene(0);
    }

    public void configGame(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void ExitOptions(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void Start()
    {
        optMenu.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            pauseMenu.SetActive(isPaused);
        }
    }
}
