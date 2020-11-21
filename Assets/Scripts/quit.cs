using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* created by Aubrey Isaacman
 *
 * this script lets you quit the game and restart the scene
*/

public class quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
