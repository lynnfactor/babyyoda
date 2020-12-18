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
        // start mando as facing AWAY from you
        this.GetComponent<SpriteRenderer>().sprite = lookingSprites[0];
    }

    void Update()
    {
        // pick a random amount of seconds between the min and max variables you set
        changeTime = Random.Range(minTime, maxTime);

        // only increase timer as long as it's less than changeTime
        if(time <= changeTime)
        {
            time += Time.deltaTime;
        }

        // if the timer reaches the changeTime
        if (time >= changeTime)
        {
            // and mando IS looking at you
            if (isLooking == true)
            {
                // change his helmet so he's looking away instead
                this.GetComponent<SpriteRenderer>().sprite = lookingSprites[0];
                // change the boolean to reflect this change
                isLooking = false;
                // and reset the timer for the next round
                time = 0;
            } /*but if mando is NOT looking at you*/ else if (isLooking == false)
            {
                // change his helmet so he IS looking at you
                this.GetComponent<SpriteRenderer>().sprite = lookingSprites[1];
                // change the boolean to reflect this change
                isLooking = true;
                // and reset the timer for the next round
                time = 0;
            }

        }

    }
}
