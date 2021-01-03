using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TensionBarControler : MonoBehaviour
{
    [SerializeField] private DoorHendler _handler = null;
    private Vector3 _endPos = Vector3.zero;
    private Vector3 _startPos = Vector3.zero;
    [SerializeField] private RectTransform _barFiller = null;
    [SerializeField] private TextMeshProUGUI _citizenCounter = null;
    [SerializeField] private TextMeshProUGUI _issueCounter = null;

    void Start()
    {
        _endPos.x = _barFiller.rect.width;


    }

    void Update()
    {
        float t = _handler.CurrentTension / _handler.MaxTension;
        _barFiller.transform.localPosition = Vector3.Lerp(_startPos, _endPos, t);

        _citizenCounter.text = "Citizen : " + _handler.CitizenNumber.ToString();
        _issueCounter.text = "Issue : " + _handler.IssueCounter.ToString();
    }
}
