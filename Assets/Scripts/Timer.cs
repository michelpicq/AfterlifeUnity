using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _chronoSeconde = 0f;
    [SerializeField] private float _chronoMinute = 0f;
    [SerializeField] public TextMeshProUGUI _displayedScoreSeconde;
    [SerializeField] public TextMeshProUGUI _displayedScoreMinute;

    void Update()
    {
        Chronometer();
    }

    public void Chronometer()
    {
        _chronoSeconde += Time.deltaTime;
        if(_chronoSeconde >=15)
        {
            _chronoMinute = _chronoMinute + 01;
            _chronoSeconde = 0;
        }
            _displayedScoreSeconde.text = Mathf.RoundToInt(_chronoSeconde).ToString();
            _displayedScoreMinute.text = Mathf.RoundToInt(_chronoMinute).ToString();
    }
}
