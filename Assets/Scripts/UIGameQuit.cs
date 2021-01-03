using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameQuit : MonoBehaviour
{
    [SerializeField] private GameObject _panelSureQuitUIGame;


    void Start()
    {
        _panelSureQuitUIGame.gameObject.SetActive(false);
    }


    void Update()
    {
        AreYouSureTouchEscape();
    }

    public void AreYouSure()
    {
        _panelSureQuitUIGame.gameObject.SetActive(true);
    }

    public void AreYouSureTouchEscape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _panelSureQuitUIGame.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void AreYouSureReturnGame()
    {
        _panelSureQuitUIGame.gameObject.SetActive(false);
        Time.timeScale = 1;

    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
