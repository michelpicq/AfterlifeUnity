using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{

    [SerializeField] private GameObject _pausedPanel = null;
    [SerializeField] private GameObject _panelSureQuit = null;

    void Start()
    {
        _pausedPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        Paused();
    }

    public void Resume()
    {

        _pausedPanel.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Paused()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _pausedPanel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void AreYouSure()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _panelSureQuit.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ReturnMainMenu()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void AreYouSureResume()
    {
        _panelSureQuit.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

}
