using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TensionBar3 : MonoBehaviour
{
    private static Image _BarDoor3;

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
        _BarDoor3.fillAmount = (1 / _TensionMax) * _ValueTension;
    }

    void Start()
    {
        _BarDoor3 = GetComponent<Image>();
        
    }

    void Update()
    {

    }
}
