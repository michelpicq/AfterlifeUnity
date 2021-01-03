using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerDoor1 : MonoBehaviour
{
    [SerializeField] protected GameObject _door1Over = null;
    [SerializeField] protected GameObject _image = null;
    [SerializeField] protected GameObject _panelDoor1 = null;

    [SerializeField] protected Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        _door1Over.gameObject.SetActive(false);
        _panelDoor1.gameObject.SetActive(false);
    }


    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        _door1Over.gameObject.SetActive(true);
    }

    void OnMouseExit()
    {
        _door1Over.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        _image.gameObject.SetActive(false);
        _panelDoor1.gameObject.SetActive(true);

    }

    private void OnMouseUp()
    {

    }



}
