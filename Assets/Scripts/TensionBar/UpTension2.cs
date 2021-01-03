using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTension2 : MonoBehaviour
{
    TensionBar2 TensionBarUp2 = new TensionBar2();
        
    void Start()
    {
        TensionBarUp2._TensionMax = 100;
        TensionBarUp2._valueTension = 0;
    }

    void Update()
    {
        //DOOR 2
    

        if (Input.GetKeyDown(KeyCode.J))
        {
            TensionBarUp2._valueTension -= 10;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            TensionBarUp2._valueTension += 10;
        }
    }
}
