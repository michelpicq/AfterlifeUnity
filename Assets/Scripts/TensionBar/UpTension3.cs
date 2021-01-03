using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTension3 : MonoBehaviour
{
    TensionBar3 TensionBarUp3 = new TensionBar3();
        
    void Start()
    {
        TensionBarUp3._TensionMax = 100;
        TensionBarUp3._valueTension = 0;
    }

    void Update()
    {
        //DOOR 3

        if (Input.GetKeyDown(KeyCode.U))
        {
            TensionBarUp3._valueTension -= 10;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            TensionBarUp3._valueTension += 10;
        }


    }
}
