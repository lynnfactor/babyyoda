using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    private GameObject theMando;

    // Start is called before the first frame update
    void Start()
    {
        u = UduinoManager.Instance;
        u.pinMode(AnalogPin.A0, PinMode.Input);
        //u.pinMode(AnalogPin.A3, PinMode.Output);

        // access variables from mando script
        theMando = GameObject.Find("Mando");
    }

    // Update is called once per frame
    void Update()
    {
        mando din = theMando.GetComponent<mando>();

        int analogVal = u.analogRead(AnalogPin.A0);

        // if baby's arm is lifting up
        if(analogVal >= 125)
        {
            // and Din is looking away
            if(din.spriteRenderer.sprite = din.lookAway)
            {
                // add to eggs eaten
                score.scoreVal += 1;

            }
            // else, if din IS looking at baby
            else if (din.spriteRenderer.sprite = din.lookFwd)
            {
                SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
            }
        }
    
        // else if mando is looking at you
        // game over
    }

/*
    void ReadFlex()
    {
        //readValue = u.analogRead(AnalogPin.A0,"PinRead");
        //u.analogWrite(AnalogPin.A3,readValue/6);
    }
    */
}
