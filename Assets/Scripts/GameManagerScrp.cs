using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScrp : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void quit()
    {
        Application.Quit();
        //Debug.Log("Quit");
    }

    public void pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
