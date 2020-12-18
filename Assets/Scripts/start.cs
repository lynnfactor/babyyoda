using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/* created by Aubrey Isaacman
 *
 * this script lets you start, quit, and restart the game
*/
public class start : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if(Input.GetKeyDown("space"))
        {
            ChangeScene();
        } 
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("test");
    }

}
