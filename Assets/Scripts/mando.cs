using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* created by Aubrey Isaacman
 *
 * Mando randomly changes from looking away to looking at you
 *
 * using this tutorial for sprite change: https://gamedevbeginner.com/how-to-change-a-sprite-from-a-script-in-unity-with-examples/
*/

public class mando : MonoBehaviour
{
    public bool isLooking = false;

    public int maxTime = 10;
    public int minTime = 3;

    // current time
    private float time;
    // time to change sprite
    private float changeTime;

    // array to change sprites
    public Sprite[] lookingSprites;


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = lookingSprites[0];
    }

    /*
    // this have a 50/50 chance of changing the boolean to true or false
    public void random50 (float fChance)
    {
        float fRand = Random.Range(0.0f, 1.0f);

        if (fRand <= fChance)
        {
            if(isLooking = false)
            {
                isLooking = true;
            }

            if (isLooking = true)
            {
                isLooking = false;
            }
        }
        //isLooking = false;
    }
    */

    void Update()
    {
        // count time
        changeTime = Random.Range(minTime, maxTime);
        Debug.Log("Change sprite in " + changeTime + "seconds");

        //random50(fChance);

        if(time <= changeTime)
        {
            time += Time.deltaTime;
            //Debug.Log("Time is: " + time);
        }


        if (time >= changeTime)
        {
            //ChangeSprite();
            if (isLooking == true)
            {
                Debug.Log("entering true if statement");
                this.GetComponent<SpriteRenderer>().sprite = lookingSprites[0];

                isLooking = false;
                time = 0;
            }

            if (isLooking == false)
            {
                Debug.Log("entering false if statement");
                this.GetComponent<SpriteRenderer>().sprite = lookingSprites[1];

                isLooking = true;
                time = 0;
            }

        }

        Debug.Log("Mando is looking: " + isLooking);

    }
}
