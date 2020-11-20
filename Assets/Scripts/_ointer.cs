using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pointer : MonoBehaviour
{
    [SerializeField] private GameObject _zone;
    [SerializeField] private GameObject _listUpgradeButton;
    [SerializeField] private GameObject _menuZone = null;
    [SerializeField] private Button _buttonMining = null;
    [SerializeField] private Renderer _rend = null;
    [SerializeField] private GameObject _mine;
    [SerializeField] private GameObject _selectedZone = null;
    [SerializeField] private GameObject _overZone = null;
    [SerializeField] private int _checkingOneSelect = 0;
    [SerializeField] private int _checkOneSelectBuiltMine = 0;

    [SerializeField] private int _zoning = 0;

    void Start()
    {
        _rend = GetComponent<Renderer>();
        _listUpgradeButton.gameObject.SetActive(false);
        _buttonMining.gameObject.SetActive(false);
        _menuZone.gameObject.SetActive(false);
        _mine.gameObject.SetActive(false);
    }


    void Update()
    {
        UpgradingMenu();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_zoning == 1)
            {
                _checkingOneSelect = _checkingOneSelect = 1;
            }

        }
    }

    void OnMouseEnter()
    {
        _overZone.gameObject.SetActive(true);
    }

    void OnMouseExit()
    {
        _overZone.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {

        if (_zoning == 1)
        {
            if (_checkingOneSelect == 0)
            {
                _selectedZone.gameObject.SetActive(true);
            }

        }

         if(_zoning == 2)
        {
            _mine.gameObject.SetActive(true);
        }

    }

    private void OnMouseUp()
    {
        
    }

    private void UpgradingMenu()
    {
        if (_selectedZone.activeSelf is true)
        {
            _buttonMining.gameObject.SetActive(true);

        }

    }

    public void OnclickButtonMine()
    {
        _selectedZone.gameObject.SetActive(false);
        _checkingOneSelect = _checkingOneSelect = 0;
    }
}
