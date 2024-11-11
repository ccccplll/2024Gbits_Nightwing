using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginSceneScript : MonoBehaviour
{
    public int storyNode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadGameScene()
    {
        SceneManager.LoadScene(this.storyNode);
    }

    public void chooseStoryNode()
    {
        SceneManager.LoadScene(1);
    }
    public void saveAndQuit()
    {
        Application.Quit();
    }
}
