using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerDoor : MonoBehaviour
{
    [SerializeField] private GameObject _doorOver = null;
    [SerializeField] private GameObject _image = null;
    [SerializeField] private GameObject _panelDoor1 = null;
    [SerializeField] private GameObject _panelDoor2 = null;
    [SerializeField] private GameObject _panelDoor3 = null;

    void Start()
    {
        _doorOver.SetActive(false);
        _panelDoor1.SetActive(false);
    }


    void Update()
    {

    }

    void OnMouseEnter()
    {
           _doorOver.SetActive(true);
    }

    void OnMouseExit()
    {
        _doorOver.SetActive(false);
    }

    void OnMouseDown()
    {
        //_image.SetActive(false);
        if (!_panelDoor1.activeSelf && !_panelDoor2.activeSelf && !_panelDoor3.activeSelf)
        {
            _panelDoor1.SetActive(true);
        }

    }

    private void OnMouseUp()
    {

    }



}