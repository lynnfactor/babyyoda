using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

/* created by Aubrey Isaacman
 * 
 * this script allows player to control game with electronics installed in baby yoda
 * Using the Uduino examples for help
*/

public class baby : MonoBehaviour
{
    UduinoManager u;
    //int readValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        u = UduinoManager.Instance;
        u.pinMode(AnalogPin.A0, PinMode.Input);
        //u.pinMode(AnalogPin.A3, PinMode.Output);
    }

    // Update is called once per frame
    void Update()
    {
        int analogVal = u.analogRead(AnalogPin.A0);
     /*   
        if(analogVal >= 130)
        {
            score.scoreVal += 1;
        }
    */

    if(Input.GetKeyDown("space"))
    {
        // if mando is looking away
        score.scoreVal += 1;
        // else if mando is looking at you
        // game over
    }

    }

/*
    void ReadFlex()
    {
        //readValue = u.analogRead(AnalogPin.A0,"PinRead");
        //u.analogWrite(AnalogPin.A3,readValue/6);
    }
    */
}
