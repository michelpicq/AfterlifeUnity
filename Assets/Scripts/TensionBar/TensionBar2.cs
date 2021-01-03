using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TensionBar2 : MonoBehaviour
{
    private static Image _BarDoor2;

    public float _TensionMax { get; set; }

    private float _ValueTension;

    public float _valueTension
    {
        get { return _ValueTension; }

        set
        {
            _ValueTension = Mathf.Clamp(value, 0, _TensionMax);

            NewMethod();
        }


    }

    private void NewMethod()
    {
        _BarDoor2.fillAmount = (1 / _TensionMax) * _ValueTension;
    }

    void Start()
    {
        _BarDoor2 = GetComponent<Image>();
        
    }

    void Update()
    {

    }
}
