using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHendler : MonoBehaviour
{
    private int _citizenNumber = 0;
    private float _currentTension = 0;
    [SerializeField] protected float _maxTension = 100;
    [SerializeField] private float _tensionByCitizen = 0.1f;
    [SerializeField] private int _decreaseTension = 50;
    [SerializeField] private int _issueThreshold = 2;
    private int _issueCounter = 0;
    private int _issueThresholdCounter = 0;

    public float MaxTension => _maxTension;
    public float CurrentTension => _currentTension;
    public int CitizenNumber => _citizenNumber;
    public int IssueCounter
    {
        get
        {
            return _issueCounter;
        }
        set
        {
            _issueCounter = value;
        }

    }

    void Start()
    {
        
    }

    void Update()
    {
        _currentTension += _citizenNumber * _tensionByCitizen * Time.deltaTime;
        _currentTension = Mathf.Clamp(_currentTension, 0, _maxTension);

        if(_currentTension >= _maxTension)
        {
            //defeat
        }
    }

    public void AddCitizen(int citizenNumber = 1)
    {
        _citizenNumber += citizenNumber;
        _issueThresholdCounter += citizenNumber;
        if(_issueThresholdCounter >= _issueThreshold)
        {
            SpawnIssue();
            _issueThresholdCounter = 0;
        }
    }

    public void DecreaseTension()
    {
        _currentTension -= _decreaseTension;
        _currentTension = Mathf.Clamp(_currentTension, 0, _maxTension);
    }
    public void SpawnIssue()
    {
        _issueCounter++;
       //spawn problème sur la porte et afficher l'ui des minis jeu
    }
}
