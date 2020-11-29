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

    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
        } 
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Main");
    }

}
