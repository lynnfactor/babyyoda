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

    public GameObject lookAway;
    public GameObject lookFwd;

    public bool isLooking;

    public int maxTime = 10;
    public int minTime = 3;

    // current time
    private float time;
    // time to change sprite
    private float changeTime;

    // Start is called before the first frame update
    void Start()
    {

        // mando starts looking away from you
        lookAway.SetActive(true);
        lookFwd.SetActive(false);

        isLooking = false;

        SetRandomTime();

    }

    // this have a 50/50 chance of changing the boolean to true or false
    public void random50 (float fChance)
    {
        float fRand = Random.Range(0.0f, 1.0f);
        if (fRand <= fChance)
        {
            isLooking = true;
        }
        isLooking = false;
    }

    void SetRandomTime()
    {
        changeTime = Random.Range(minTime,maxTime);
        Debug.Log("Change time is " + changeTime);

        FixedUpdate();
    }

    void FixedUpdate()
    {
        // count time
        time += Time.deltaTime;

        if (time >= changeTime)
        {
            Debug.Log("Change sprite in " + changeTime + " seconds");
            ChangeSprite();
        }
    }

    void ChangeSprite()
    {
        // check which sprite is loaded
        // then change it to the other one

        if(isLooking == true)
        {
            lookAway.SetActive(false);
            lookFwd.SetActive(true);
        } 

        if (isLooking == false)
        {
            lookAway.SetActive(true);
            lookFwd.SetActive(true);
        }

        SetRandomTime();
    }
}
