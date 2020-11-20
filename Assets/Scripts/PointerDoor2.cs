using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointerDoor2 : MonoBehaviour
{
    [SerializeField] private GameObject _door2Over = null;
    [SerializeField] private GameObject _folderDoor = null;
    [SerializeField] private GameObject _image = null;
    [SerializeField] private GameObject _groupPanelDoor = null;
    [SerializeField] private GameObject _panelDoor2 = null;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        _door2Over.gameObject.SetActive(false);
        _groupPanelDoor.gameObject.SetActive(false);
    }


    void Update()
    {

    }

    void OnMouseEnter()
    {
        _door2Over.gameObject.SetActive(true);
    }

    void OnMouseExit()
    {
        _door2Over.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        _folderDoor.gameObject.SetActive(false);
        _image.gameObject.SetActive(false);
        //_groupPanelDoor.gameObject.SetActive(true);
        _panelDoor2.gameObject.SetActive(true);

    }

    private void OnMouseUp()
    {

    }



}