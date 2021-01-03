using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenHandler : MonoBehaviour
{
    [SerializeField] private float _randomRangeCitizenMin = 1f;
    [SerializeField] private float _randomRangeCitizenMax = 5f;
    private float _timeStamp = 0;
    private float _timeToSpawn = 0;
    [SerializeField] private List<DoorHendler> _doors = null;


    void Start()
    {
        //_doors = new List<DoorHendler>();
        _timeToSpawn = Random.Range(_randomRangeCitizenMin, _randomRangeCitizenMax);

    }

    void Update()
    {
        _timeStamp += Time.deltaTime;
        if(_timeStamp >= _timeToSpawn)
        {
            _timeStamp = 0;
            _timeToSpawn = Random.Range(_randomRangeCitizenMin, _randomRangeCitizenMax);
            int index = Random.Range(0, _doors.Count);
            _doors[index].AddCitizen();


        }
    }
}
