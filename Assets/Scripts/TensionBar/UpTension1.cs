using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTension1 : MonoBehaviour
{
    TensionBar1 TensionBarUp1 = new TensionBar1();
        
    void Start()
    {
        TensionBarUp1._TensionMax = 100;
        TensionBarUp1._valueTension = 0;
    }

    void Update()
    {

    //DOOR 1
        if(Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            TensionBarUp1._valueTension -= 10;
        }

        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            TensionBarUp1._valueTension += 10;
        }

    }
}
