using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* created by Aubrey Isaacman
 *
 * this script changes the score text element to update the game score on screen
 * followed this tutorial: https://www.youtube.com/watch?v=QbqnDbexrCw&vl=en&ab_channel=AlexanderZotov
*/

public class score : MonoBehaviour
{
    public static int scoreVal = 0;
    Text eggscore;

    // Start is called before the first frame update
    void Start()
    {
        eggscore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        eggscore.text = "Eggs Eaten : " + scoreVal; 
    }
}
