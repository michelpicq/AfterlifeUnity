using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuScripts : MonoBehaviour
{
    [SerializeField] private GameObject _panelOption;
    [SerializeField] private GameObject _mainMenuGroup;
    [SerializeField] private GameObject _panelSureQuit;


    void Start()
    {
        Time.timeScale = 0;
        _panelOption.gameObject.SetActive(false);
        _mainMenuGroup.gameObject.SetActive(true);
    }

    private void Update()
    {
        AreYouSureTouchEscape();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OptionMenu()
    {
        _panelOption.gameObject.SetActive(true);
        _mainMenuGroup.gameObject.SetActive(false);
    }

    public void OptionReturnFirstMenu()
    {
        _panelOption.gameObject.SetActive(false);
        _mainMenuGroup.gameObject.SetActive(true);
    }

    public void AreYouSure()
    {
            _panelSureQuit.gameObject.SetActive(true);
            _mainMenuGroup.gameObject.SetActive(false);
    }

    public void AreYouSureTouchEscape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _panelSureQuit.gameObject.SetActive(true);
            _mainMenuGroup.gameObject.SetActive(false);
        }
    }

    public void AreYouSureReturnFirstMenu()
    {
        _panelSureQuit.gameObject.SetActive(false);
        _mainMenuGroup.gameObject.SetActive(true);


    }
}
