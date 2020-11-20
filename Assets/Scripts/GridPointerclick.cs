using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GridPointerclick : MonoBehaviour

{

    [SerializeField] private bool _Mybool = false;
    [SerializeField] private GameObject _zone;
    [SerializeField] private GameObject _listUpgradeButton;
    [SerializeField] private GameObject _menuZone;
    [SerializeField] private Material _selectedZone;
    [SerializeField] private Material _unselectedZone;
    [SerializeField] private List<GameObject> _zonning = new List<GameObject>();


    void Start()
    {
        _menuZone.gameObject.SetActive(false);
        _listUpgradeButton.gameObject.SetActive(false);
    }
}
 
