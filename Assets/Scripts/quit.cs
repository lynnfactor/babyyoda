using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* created by Aubrey Isaacman
 *
 * this script lets you quit the game and restart the scene
 * also scene change on button click
*/

public class quit : MonoBehaviour
{

    [SerializeField] private string scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.Q)))
        {
            QuitGame();
        }

        /*
        if ((Input.GetKey(KeyCode.R)))
        {
            Debug.Log("r pressed");
            RestartGame();
        }*/
    }

    public void MoveScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit game");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
