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

    //check if the flex sensor has been pressed already
    public bool flexOn = false;

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

        // has the flex sensor been pressed already?
        if(flexOn == false)
        {
            // if baby's arm is lifting up
            if(analogVal >= 125 || Input.GetKeyDown("space"))
            {
                // and Din is looking away
                if(din.spriteRenderer.sprite = din.lookAway)
                {
                    // add to eggs eaten
                    score.scoreVal += 1;
                    if(score.scoreVal == 10)
                    {
                        // if you eat 10 eggs, you win
                        SceneManager.LoadScene("Win", LoadSceneMode.Additive);
                    }
                }
                // else, if din IS looking at baby
                else if (din.spriteRenderer.sprite = din.lookFwd)
                {
                    // you lose
                    SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
                }

                // change bool to true because the flex sensor is on now
                flexOn = true;
            }
        }

        // if flex sensor is flatter again, make bool false
        if(flexOn == true)
        {
            if(analogVal <= 124 || Input.GetKeyUp("space"))
            {
                flexOn = false;
            }
        }
    
    }


}
