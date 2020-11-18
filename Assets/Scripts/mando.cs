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

    public SpriteRenderer spriteRenderer;
    public Sprite lookAway;
    public Sprite lookFwd;
    //public Sprite newImage;
    //public Image imageComponent;

    public int maxTime = 10;
    public int minTime = 3;

    // current time
    private float time;
    // time to change sprite
    private float changeTime;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = lookAway;
        //imageComponent = this.GetComponent<Image>();
        //imageComponent.sprite = lookAway;

        SetRandomTime();

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

        if(spriteRenderer.sprite == lookAway)
        {
            spriteRenderer.sprite = lookFwd;
        } 

        if (spriteRenderer.sprite == lookFwd)
        {
            spriteRenderer.sprite = lookAway;
        }

        Debug.Log("Sprite is " + spriteRenderer.sprite);

        SetRandomTime();
    }
}
