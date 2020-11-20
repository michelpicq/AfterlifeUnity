using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerDoor3 : MonoBehaviour
{
    [SerializeField] public GameObject _door3Over = null;
    [SerializeField] public GameObject _folderDoor = null;
    [SerializeField] public GameObject _image = null;
    [SerializeField] public GameObject _groupPanelDoor = null;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        _door3Over.gameObject.SetActive(false);
        _groupPanelDoor.gameObject.SetActive(false);
    }


    void Update()
    {

    }

    void OnMouseEnter()
    {
        _door3Over.gameObject.SetActive(true);
    }

    void OnMouseExit()
    {
        _door3Over.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        _folderDoor.gameObject.SetActive(false);
        _image.gameObject.SetActive(false);
        _groupPanelDoor.gameObject.SetActive(true);

    }

    private void OnMouseUp()
    {

    }



}