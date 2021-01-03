using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMiniGames : MonoBehaviour
{
    [SerializeField] private int _clickNumber = 5;
    private int _clickCounter = 0;
    [SerializeField] DoorPanelHandler _doorPanelHandler = null;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Click()
    {
        _clickCounter++;
        if(_clickCounter >= _clickNumber)
        {
            _doorPanelHandler.OnWinMiniGames();
            Reset();
        }
    }

    public void Reset()
    {
        _clickCounter = 0;
    }

    private void OnEnable()
    {
        Reset();
    }

}
