using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointerDoor2 : MonoBehaviour
{
    [SerializeField] private GameObject _door2Over = null;
    [SerializeField] private GameObject _image = null;
    [SerializeField] private GameObject _panelDoor2 = null;

    [SerializeField] protected Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        _door2Over.gameObject.SetActive(false);
        _panelDoor2.gameObject.SetActive(false);
    }


    void Update()
    {

    }

    void OnMouseEnter()
    {
        _door2Over.gameObject.SetActive(true);
        //Si la souris entre dans la zone de la porte 2 une surbrillance apparait.
    }

    void OnMouseExit()
    {
        _door2Over.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        _image.gameObject.SetActive(false);
        _panelDoor2.gameObject.SetActive(true);

    }

    private void OnMouseUp()
    {

    }



}